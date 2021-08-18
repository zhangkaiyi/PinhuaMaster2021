﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions;
using PinhuaMaster.Pages.OrderManagement.EasyDelivery.ViewModel;

namespace PinhuaMaster.Pages.OrderManagement.EasyDelivery
{
    public class EditModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;

        public EditModel(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        public List<SelectListItem> DeliveryTypes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> ContactsSelectList { get; set; } = new List<SelectListItem>();
        public List<往来单位联系人> ContactsList { get; set; }

        [BindProperty]
        public Gi2ViewModel Order { get; set; } = new Gi2ViewModel();

        public void OnGet(string Id)
        {
            DeliveryTypes = BuildTypes();
            Customers = _pinhuaContext.GetCustomerSelectList();
            ContactsSelectList = _pinhuaContext.GetContactsSelectList();
            ContactsList = _pinhuaContext.往来单位联系人.ToList();

            Order.Main = _mapper.Map<Gi2Main, Gi2MainDTO>(_pinhuaContext.Gi2Main.AsNoTracking().Where(p => p.DeliveryId == Id).FirstOrDefault());
            Order.Details = _mapper.Map<List<Gi2Details>, List<Gi2DetaislDTO>>(_pinhuaContext.Gi2Details.AsNoTracking().Where(p => p.DeliveryId == Id).ToList());

        }

        public async Task<IActionResult> OnPost()
        {
            var remoteOrder = _pinhuaContext.Gi2Main.FirstOrDefault(p => p.DeliveryId == Order.Main.DeliveryId);
            if (remoteOrder == null)
            {
                ModelState.AddModelError("", $"单号为 {Order.Main.DeliveryId} 的送货单不存在，操作失败。");
                return Page();
            }

            // 对主表的缺失信息赋值，ExcelServerRcid，ExcelServerRtid，其他
            Order.Main.ExcelServerRcid = remoteOrder.ExcelServerRcid;
            Order.Main.ExcelServerRtid = remoteOrder.ExcelServerRtid;
            Order.Main.CustomerName = _pinhuaContext.往来单位.FirstOrDefault(p => p.单位编号 == Order.Main.CustomerId).单位名称;
            // 将修改标记到数据库中跟踪的数据，remoteOrder
            _mapper.Map<Gi2MainDTO, Gi2Main>(Order.Main, remoteOrder);
            // 对明细表的缺失信息赋值
            Order.Details.ForEach(i =>
            {
                i.ExcelServerRcid = remoteOrder.ExcelServerRcid;
                i.ExcelServerRtid = remoteOrder.ExcelServerRtid;
                i.DeliveryId = remoteOrder.DeliveryId;
            });
            Order.Details.ForEach(i =>
            {
                var result = _pinhuaContext.Gi2Details.FirstOrDefault(p => p.DeliveryId == i.DeliveryId && p.Id == i.Id);
                if (result == null)
                    // 如果该条信息不存在，则添加
                    _pinhuaContext.Gi2Details.Add(_mapper.Map<Gi2DetaislDTO, Gi2Details>(i));
                else
                {
                    // 如果该条信息存在，则修改
                    _mapper.Map<Gi2DetaislDTO, Gi2Details>(i, result);
                }
            });
            await _pinhuaContext.Gi2Details.Where(p => p.DeliveryId == remoteOrder.DeliveryId).ForEachAsync(i =>
            {
                var result = Order.Details.FirstOrDefault(p => p.Id == i.Id);
                if (result == null)
                    // 如果该条信息多余，则删除
                    _pinhuaContext.Gi2Details.Remove(i);
            });

            // 保存修改
            await _pinhuaContext.SaveChangesAsync();
            return RedirectToPage("Index");
        }

        private List<SelectListItem> BuildTypes()
        {
            var types = (from p in _pinhuaContext.业务类型.AsNoTracking()
                        where p.状态 == "Yes" && p.MvP == "GI"
                        select p).ToList();
            var groups = from p in types
                         group p by p.MvP into g
                         select g.Key;
            var groupingTypes = new List<SelectListItem>();
            foreach (var group in groups)
            {
                var optGroup = new SelectListGroup
                {
                    Name = group
                };
                foreach (var option in types)
                {
                    if (option.MvP == group)
                    {
                        groupingTypes.Add(new SelectListItem
                        {
                            Group = optGroup,
                            Text = option.业务类型1 + " - " + option.类型描述,
                            Value = option.业务类型1,
                        });
                    }
                }
            }
            return groupingTypes;
        }
    }
}