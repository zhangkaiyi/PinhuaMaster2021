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
using PinhuaMaster.Data.Entities.Pinhua;
using PinhuaMaster.Extensions;
using PinhuaMaster.Pages.ProductionManagement.ProductionOrder.ViewModel;

namespace PinhuaMaster.Pages.ProductionManagement.ProductionOrder
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
        public vm生产单 Order { get; set; } = new vm生产单();
        public List<SelectListItem> PartnerSelectList { get; set; } = new List<SelectListItem>();

        public void OnGet(string Id)
        {
            PartnerSelectList = _pinhuaContext.GetCustomerSelectList();

            Order.M = _mapper.Map<生产单, dto生产单M>(_pinhuaContext.生产单.AsNoTracking().Where(p => p.单号 == Id).FirstOrDefault());
            Order.D = _mapper.Map<List<生产单d>, List<dto生产单D>>(_pinhuaContext.生产单d.AsNoTracking().Where(p => p.ExcelServerRcid == Order.M.ExcelServerRcid).ToList());
            foreach (var d in Order.D)
            {
                var casePic = _pinhuaContext.EsCasePic.FirstOrDefault(p => p.PicNo == d.图片);
                if (casePic != null)
                {
                    d.图片base64 = $"data:{d.图片type ?? "image/jpeg"};base64," + Convert.ToBase64String(casePic.Img);
                }
            }
        }

        public IActionResult OnPost()
        {
            var remoteOrder = _pinhuaContext.生产单.FirstOrDefault(p => p.单号 == Order.M.单号);
            if (remoteOrder == null)
            {
                ModelState.AddModelError("", $"单号为 {Order.M.单号} 的生产订单不存在，操作失败。");
                PartnerSelectList = _pinhuaContext.GetCustomerSelectList();
                return Page();
            }

            // 对主表的缺失信息赋值，ExcelServerRcid，ExcelServerRtid，其他
            Order.M.ExcelServerRcid = remoteOrder.ExcelServerRcid;
            Order.M.ExcelServerRtid = remoteOrder.ExcelServerRtid;
            Order.M.客户名 = _pinhuaContext.往来单位.FirstOrDefault(p => p.单位编号 == Order.M.客户号).单位名称;
            // 将修改标记到数据库中跟踪的数据，remoteOrder
            _mapper.Map<dto生产单M, 生产单>(Order.M, remoteOrder);
            // 删除明细表的老数据
            var remoteDetails = _pinhuaContext.生产单d.Where(p => p.ExcelServerRcid == remoteOrder.ExcelServerRcid);
            _pinhuaContext.生产单d.RemoveRange(remoteDetails);
            // 删除旧的图片数据
            var oldCasePic = _pinhuaContext.EsCasePic.Where(p => p.RcId == remoteOrder.ExcelServerRcid);
            _pinhuaContext.EsCasePic.RemoveRange(oldCasePic);
            // 对明细表的缺失信息赋值
            Order.D.ForEach(i =>
            {
                var newRecord = new 生产单d
                {
                    ExcelServerRcid = remoteOrder.ExcelServerRcid,
                    ExcelServerRtid = remoteOrder.ExcelServerRtid,
                    长 = i.长,
                    宽 = i.宽,
                    高 = i.高,
                    片数 = i.片数,
                    刻线要求 = i.刻线要求,
                    拉丝要求 = i.拉丝要求,
                    开槽要求 = i.开槽要求,
                    油漆要求 = i.油漆要求,
                    描述 = i.描述,
                    其他要求 = i.其他要求,
                    是否刻线 = i.是否刻线,
                    是否拉丝 = i.是否拉丝,
                    是否开槽 = i.是否开槽,
                    是否油漆 = i.是否油漆,
                    图片name = i.图片name,
                    图片type = i.图片type,
                };
                if (!string.IsNullOrEmpty(i.图片base64))   // base64非空，插入图片
                {
                    var picNo = _pinhuaContext.GetNewPicNo();
                    var newBase64 = i.图片base64.Substring(i.图片base64.IndexOf(',') + 1);
                    _pinhuaContext.EsCasePic.Add(new EsCasePic
                    {
                        RcId = remoteOrder.ExcelServerRcid,
                        PicNo = picNo,
                        Img = Convert.FromBase64String(newBase64),
                        FileType = string.IsNullOrEmpty(i.图片name) ? ".jpg" : i.图片name.Substring(i.图片name.LastIndexOf(".")),
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
            });

            // 保存修改
            _pinhuaContext.SaveChanges();

            return RedirectToPage("Index");
        }

        public IActionResult OnPostFinishOrder(string Id)
        {
            var order = _pinhuaContext.生产单.FirstOrDefault(p => p.单号 == Id);
            if (order != null)
            {
                order.状态 = "完成";
                _pinhuaContext.SaveChanges();

                return new JsonResult("result:ok");
            }
            else
                return new JsonResult("result:fail");
        }

        public IActionResult OnPostFinishCancel(string Id)
        {
            var order = _pinhuaContext.生产单.FirstOrDefault(p => p.单号 == Id);
            if (order != null)
            {
                order.状态 = "进行中";
                _pinhuaContext.SaveChanges();

                return new JsonResult("result:ok");
            }
            else
                return new JsonResult("result:fail");
        }
    }
}