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
using PinhuaMaster.Pages.BasicInformation.Partner.ViewModel;

namespace PinhuaMaster.Pages.BasicInformation.Partner
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
        public PartnerDTO PartnerInfo { get; set; } = new PartnerDTO();

        public void OnGet(string Id)
        {
            PartnerInfo = _mapper.Map<往来单位, PartnerDTO>(_pinhuaContext.往来单位.AsNoTracking().Where(p => p.单位编号 == Id).FirstOrDefault());
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var remoteOrder = _pinhuaContext.往来单位.FirstOrDefault(p => p.单位编号 == PartnerInfo.单位编号);
                if (remoteOrder == null)
                {
                    ModelState.AddModelError("", $"单号为 {PartnerInfo.单位名称} 的送货单不存在，操作失败。");
                    return Page();
                }

                // 对主表的缺失信息赋值，ExcelServerRcid，ExcelServerRtid，其他
                PartnerInfo.ExcelServerRcid = remoteOrder.ExcelServerRcid;
                PartnerInfo.ExcelServerRtid = remoteOrder.ExcelServerRtid;
                // 将修改标记到数据库中跟踪的数据，remoteOrder
                _mapper.Map<PartnerDTO, 往来单位>(PartnerInfo, remoteOrder);

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