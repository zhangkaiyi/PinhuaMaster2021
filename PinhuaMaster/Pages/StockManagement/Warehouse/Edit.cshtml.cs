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
using PinhuaMaster.Pages.StockManagement.Warehouse.ViewModel;

namespace PinhuaMaster.Pages.StockManagement.Warehouse
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
        public WarehouseViewModel Order { get; set; } = new WarehouseViewModel();

        public void OnGet(string Id)
        {

            Order.Main = _mapper.Map<Data.Entities.Pinhua.Warehouse, WarehouseDTO>(_pinhuaContext.Warehouse.AsNoTracking().Where(p => p.Id == Id).FirstOrDefault());

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var remoteOrder = _pinhuaContext.Warehouse.FirstOrDefault(p => p.Id == Order.Main.Id);
                if (remoteOrder == null)
                {
                    ModelState.AddModelError("", $"单号为 {Order.Main.Id} 的送货单不存在，操作失败。");
                    return Page();
                }

                // 对主表的缺失信息赋值，ExcelServerRcid，ExcelServerRtid，其他
                Order.Main.ExcelServerRcid = remoteOrder.ExcelServerRcid;
                Order.Main.ExcelServerRtid = remoteOrder.ExcelServerRtid;
                // 将修改标记到数据库中跟踪的数据，remoteOrder
                _mapper.Map<WarehouseDTO, Data.Entities.Pinhua.Warehouse>(Order.Main, remoteOrder);

                // 保存修改
                await _pinhuaContext.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}