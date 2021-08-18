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
using PinhuaMaster.Pages.BasicInformation.ModelNumber.ViewModel;

namespace PinhuaMaster.Pages.BasicInformation.ModelNumber
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
        public ModelNumberDTO ModelNumberInfo { get; set; } = new ModelNumberDTO();

        public void OnGet(string Id)
        {

            ModelNumberInfo = _mapper.Map<Data.Entities.Pinhua.产品型号清单, ModelNumberDTO>(_pinhuaContext.产品型号清单.AsNoTracking().Where(p => p.编号 == Id).FirstOrDefault());

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var remoteOrder = _pinhuaContext.产品型号清单.FirstOrDefault(p => p.编号 == ModelNumberInfo.ModelNumber);
                if (remoteOrder == null)
                {
                    ModelState.AddModelError("", $"单号为 {ModelNumberInfo.ModelNumber} 的送货单不存在，操作失败。");
                    return Page();
                }

                // 对主表的缺失信息赋值，ExcelServerRcid，ExcelServerRtid，其他
                ModelNumberInfo.ExcelServerRcid = remoteOrder.ExcelServerRcid;
                ModelNumberInfo.ExcelServerRtid = remoteOrder.ExcelServerRtid;
                // 将修改标记到数据库中跟踪的数据，remoteOrder
                _mapper.Map<ModelNumberDTO, Data.Entities.Pinhua.产品型号清单>(ModelNumberInfo, remoteOrder);

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