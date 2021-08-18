using System;
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
using PinhuaMaster.Pages.OrderManagement.EasyPurchasing.ViewModel;

namespace PinhuaMaster.Pages.OrderManagement.EasyPurchasing
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

        [BindProperty]
        public PurchasingViewModel Purchasing { get; set; } = new PurchasingViewModel();

        public void OnGet(string Id)
        {
            Purchasing.PurchasingTypes = buildPurchasingTypes();
            Purchasing.SupplierList = _pinhuaContext.GetCustomerSelectList();

            Purchasing.Main = _mapper.Map<Gr2Main, Gr2MainDto>(_pinhuaContext.Gr2Main.AsNoTracking().Where(p => p.PurchasingId == Id).FirstOrDefault());
            Purchasing.Details = _mapper.Map<List<Gr2Details>, List<Gr2DetailsDto>>(_pinhuaContext.Gr2Details.AsNoTracking().Where(p => p.PurchasingId == Id).ToList());
        }

        public async Task<IActionResult> OnPost()
        {
            var remoteOrder = _pinhuaContext.Gr2Main.FirstOrDefault(p => p.PurchasingId == Purchasing.Main.PurchasingId);
            if (remoteOrder == null)
            {
                ModelState.AddModelError("", $"单号为 {Purchasing.Main.PurchasingId} 的送货单不存在，操作失败。");
                return Page();
            }

            // 对主表的缺失信息赋值，ExcelServerRcid，ExcelServerRtid，其他
            Purchasing.Main.ExcelServerRcid = remoteOrder.ExcelServerRcid;
            Purchasing.Main.ExcelServerRtid = remoteOrder.ExcelServerRtid;
            Purchasing.Main.SupplierName = _pinhuaContext.往来单位.FirstOrDefault(p => p.单位编号 == Purchasing.Main.Supplier).单位名称;
            // 将修改标记到数据库中跟踪的数据，remoteOrder
            _mapper.Map<Gr2MainDto, Gr2Main>(Purchasing.Main, remoteOrder);
            // 对明细表的缺失信息赋值
            Purchasing.Details.ForEach(i =>
            {
                i.ExcelServerRcid = remoteOrder.ExcelServerRcid;
                i.ExcelServerRtid = remoteOrder.ExcelServerRtid;
                i.PurchasingId = remoteOrder.PurchasingId;
            });
            Purchasing.Details.ForEach(i =>
            {
                var result = _pinhuaContext.Gr2Details.FirstOrDefault(p => p.PurchasingId == i.PurchasingId && p.ItemId == i.ItemId);
                if (result == null)
                    // 如果该条信息不存在，则添加
                    _pinhuaContext.Gr2Details.Add(_mapper.Map<Gr2DetailsDto, Gr2Details>(i));
                else
                {
                    // 如果该条信息存在，则修改
                    _mapper.Map<Gr2DetailsDto, Gr2Details>(i, result);
                }
            });
            await _pinhuaContext.Gr2Details.Where(p => p.PurchasingId == remoteOrder.PurchasingId).ForEachAsync(i =>
            {
                var result = Purchasing.Details.FirstOrDefault(p => p.ItemId == i.ItemId);
                if (result == null)
                    // 如果该条信息多余，则删除
                    _pinhuaContext.Gr2Details.Remove(i);
            });

            // 保存修改
            await _pinhuaContext.SaveChangesAsync();
            return RedirectToPage("Index");
        }

        private List<SelectListItem> buildPurchasingTypes()
        {
            var types = (from p in _pinhuaContext.业务类型.AsNoTracking()
                         where p.状态 == "Yes" && p.MvP == "GR"
                         select p
                         ).ToList();
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