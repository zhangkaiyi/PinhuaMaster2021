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
using PinhuaMaster.Pages.StockManagement.StockOut.ViewModel;

namespace PinhuaMaster.Pages.StockManagement.StockOut
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
        public StockOutViewModel Order { get; set; } = new StockOutViewModel();

        public void OnGet(string Id)
        {
            Order.MovementTypeList = BuildTypes();
            Order.CustomerList = _pinhuaContext.GetCustomerSelectList();
            Order.WarehouseList = _pinhuaContext.GetWarehouseSelectList();

            Order.Main = _mapper.Map<StockOutMain, StockOutMainDTO>(_pinhuaContext.StockOutMain.AsNoTracking().Where(p => p.OrderId == Id).FirstOrDefault());
            Order.Details = _mapper.Map<List<StockOutDetails>, List<StockOutDetailsDTO>>(_pinhuaContext.StockOutDetails.AsNoTracking().Where(p => p.OrderId == Id).ToList());

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var remoteOrder = _pinhuaContext.StockOutMain.FirstOrDefault(p => p.OrderId == Order.Main.OrderId);
                if (remoteOrder == null)
                {
                    ModelState.AddModelError("", $"单号为 {Order.Main.OrderId} 的送货单不存在，操作失败。");
                    return Page();
                }

                // 对主表的缺失信息赋值，ExcelServerRcid，ExcelServerRtid，其他
                Order.Main.ExcelServerRcid = remoteOrder.ExcelServerRcid;
                Order.Main.ExcelServerRtid = remoteOrder.ExcelServerRtid;
                Order.Main.CustomerName = _pinhuaContext.往来单位.FirstOrDefault(p => p.单位编号 == Order.Main.CustomerId).单位名称;
                // 将修改标记到数据库中跟踪的数据，remoteOrder
                _mapper.Map<StockOutMainDTO, StockOutMain>(Order.Main, remoteOrder);
                // 对明细表的缺失信息赋值
                Order.Details.ForEach(i =>
                {
                    i.ExcelServerRcid = remoteOrder.ExcelServerRcid;
                    i.ExcelServerRtid = remoteOrder.ExcelServerRtid;
                    i.OrderId = remoteOrder.OrderId;
                });
                Order.Details.ForEach(i =>
                {
                    var result = _pinhuaContext.StockOutDetails.FirstOrDefault(p => p.OrderId == i.OrderId && p.Id == i.Id);
                    if (result == null)
                    // 如果该条信息不存在，则添加
                    _pinhuaContext.StockOutDetails.Add(_mapper.Map<StockOutDetailsDTO, StockOutDetails>(i));
                    else
                    {
                    // 如果该条信息存在，则修改
                    _mapper.Map<StockOutDetailsDTO, StockOutDetails>(i, result);
                    }
                });
                await _pinhuaContext.StockOutDetails.Where(p => p.OrderId == remoteOrder.OrderId).ForEachAsync(i =>
                {
                    var result = Order.Details.FirstOrDefault(p => p.Id == i.Id);
                    if (result == null)
                    // 如果该条信息多余，则删除
                    _pinhuaContext.StockOutDetails.Remove(i);
                });

                // 保存修改
                await _pinhuaContext.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                Order.MovementTypeList = BuildTypes();
                Order.CustomerList = _pinhuaContext.GetCustomerSelectList();
                Order.WarehouseList = _pinhuaContext.GetWarehouseSelectList();
                return Page();
            }
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