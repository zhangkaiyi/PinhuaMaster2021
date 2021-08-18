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
using PinhuaMaster.Pages.BasicInformation.ProductRegistration.ViewModel;

namespace PinhuaMaster.Pages.BasicInformation.ProductRegistration
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
        public ProductRegistrationDTO ProductRegistrationInfo { get; set; } = new ProductRegistrationDTO();

        public void OnGet(string ModelNumber, int SubModelNumber)
        {
            ProductRegistrationInfo = _mapper.Map<ProductRegistrationMain, ProductRegistrationDTO>(_pinhuaContext.ProductRegistrationMain.AsNoTracking().Where(p => p.ModelNumber == ModelNumber && p.SubModelNumber == SubModelNumber).FirstOrDefault());
            ProductRegistrationInfo.ModelName = _pinhuaContext.产品型号清单.FirstOrDefault(p => p.编号 == ModelNumber)?.名称;
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var remoteOrder = _pinhuaContext.ProductRegistrationMain.FirstOrDefault(p => p.ModelNumber == ProductRegistrationInfo.ModelNumber && p.SubModelNumber == ProductRegistrationInfo.SubModelNumber);
                if (remoteOrder == null)
                {
                    ModelState.AddModelError("", $"单号为 {ProductRegistrationInfo.ModelNumber} 的送货单不存在，操作失败。");
                    return Page();
                }

                // 对主表的缺失信息赋值，ExcelServerRcid，ExcelServerRtid，其他
                ProductRegistrationInfo.ExcelServerRcid = remoteOrder.ExcelServerRcid;
                ProductRegistrationInfo.ExcelServerRtid = remoteOrder.ExcelServerRtid;
                // 将修改标记到数据库中跟踪的数据，remoteOrder
                _mapper.Map<ProductRegistrationDTO, ProductRegistrationMain>(ProductRegistrationInfo, remoteOrder);

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