using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions;
using PinhuaMaster.Pages.ProductionManagement.ProductionOrder.ViewModel;

namespace PinhuaMaster.Pages.ProductionManagement.ProductionOrder
{
    public class CreateModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateModel> _logger;

        public CreateModel(PinhuaContext pinhuaContext, IMapper mapper, ILogger<CreateModel> logger)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
            _logger = logger;
        }

        [BindProperty]
        public ViewModel.vm生产单 Order { get; set; }
        [BindProperty]
        public List<IFormFile> Files { get; set; }

        public List<SelectListItem> PartnerSelectList { get; set; } = new List<SelectListItem>();

        public void OnGet()
        {
            PartnerSelectList = _pinhuaContext.GetCustomerSelectList();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var Rcid = _pinhuaContext.GetNewRcId();
                var rtId = "179.1";
                var repCase = new EsRepCase
                {
                    RcId = Rcid,
                    RtId = rtId,
                    LstFiller = 2,
                    LstFillerName = "116307766@qq.com",
                    LstFillDate = DateTime.Now,
                    //fillDate = DateTime.Now,
                    //wiId = "",
                    //state = 1,
                };

                var main = _mapper.Map<dto生产单M, 生产单>(Order.M);
                main.单号 = _pinhuaContext.GetZkyAutoId(181);
                main.ExcelServerRcid = Rcid;
                main.ExcelServerRtid = rtId;
                main.客户名 = _pinhuaContext.往来单位.AsNoTracking().FirstOrDefault(p => p.单位编号 == Order.M.客户号).单位名称;

                if (Order?.D?.Count == 0)
                {
                    ModelState.AddModelError("", "产品清单不可为空");
                    PartnerSelectList = _pinhuaContext.GetCustomerSelectList();
                    return Page();
                }

                foreach (var d in Order.D)
                {
                    var newRecord = new 生产单d
                    {
                        ExcelServerRcid = Rcid,
                        ExcelServerRtid = rtId,
                        长 = d.长,
                        宽 = d.宽,
                        高 = d.高,
                        片数 = d.片数,
                        刻线要求 = d.刻线要求,
                        拉丝要求 = d.拉丝要求,
                        开槽要求 = d.开槽要求,
                        油漆要求 = d.油漆要求,
                        描述 = d.描述,
                        其他要求 = d.其他要求,
                        是否刻线 = d.是否刻线,
                        是否拉丝 = d.是否拉丝,
                        是否开槽 = d.是否开槽,
                        是否油漆 = d.是否油漆,
                        图片name = d.图片name,
                        图片type = d.图片type,
                    };
                    if (!string.IsNullOrEmpty(d.图片base64))   // base64非空，插入图片
                    {
                        var picNo = _pinhuaContext.GetNewPicNo();
                        var newBase64 = d.图片base64.Substring(d.图片base64.IndexOf(',') + 1);
                        _pinhuaContext.EsCasePic.Add(new EsCasePic
                        {
                            RcId = Rcid,
                            PicNo = picNo,
                            Img = Convert.FromBase64String(newBase64),
                            FileType = string.IsNullOrEmpty(d.图片name) ? ".jpg" : d.图片name.Substring(d.图片name.LastIndexOf(".")),
                            RtfId = 2573,
                            Sh = 2,
                            R = 21,
                            C = 51,
                            IsNew = 0,
                            Rng = null,
                            SaveInto = 0,
                            NfsfolderId = 0,
                            Nfsfolder = "",
                            PhyFileName = "",
                            RelaFolder = ""
                        });
                        newRecord.图片 = picNo;
                    }
                    _pinhuaContext.生产单d.Add(newRecord);
                }
                _pinhuaContext.EsRepCase.Add(repCase);
                _pinhuaContext.生产单.Add(main);
                _pinhuaContext.SaveChanges();

                return RedirectToPage("Index");
            }
            else
            {
                PartnerSelectList = _pinhuaContext.GetCustomerSelectList();
                return Page();
            }
        }

        public IActionResult OnPostAjaxSubmit(vm生产单 Order)
        {
            return new JsonResult("result:参数填写错误, 请检查!");
        }
    }
}