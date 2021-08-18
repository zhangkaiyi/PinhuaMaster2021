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
    public class CreateModel : PageModel
    {
        private readonly PinhuaContext _pinhuaContext;
        private readonly IMapper _mapper;

        public CreateModel(PinhuaContext pinhuaContext, IMapper mapper)
        {
            _pinhuaContext = pinhuaContext;
            _mapper = mapper;
        }

        [BindProperty]
        public PurchasingViewModel Purchasing { get; set; } = new PurchasingViewModel();

        public string PurchasingId
        {
            get
            {
                return buildPurchasingId();
            }
        }

        public List<SelectListItem> PurchasingTypes { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> SupplierList { get; set; } = new List<SelectListItem>();

        public void OnGet()
        {
            Purchasing.PurchasingTypes = buildPurchasingTypes();
            Purchasing.SupplierList = _pinhuaContext.GetCustomerSelectList();

            Purchasing.Main.PurchasingId = buildPurchasingId();
            Purchasing.Main.CreatedBy = User.Identity.Name;
            Purchasing.Main.CreatedDate = DateTime.Now;
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var Rcid = _pinhuaContext.GetNewRcId();
                var rtId = _pinhuaContext.GetRtId("入库简易版");
                var repCase = new EsRepCase
                {
                    RcId = Rcid,
                    RtId = rtId,
                    LstFiller = 2,
                    LstFillerName = User.Identity.Name,
                    LstFillDate = DateTime.Now,
                    //fillDate = DateTime.Now,
                    //wiId = "",
                    //state = 1,
                };
                var main = _mapper.Map<Gr2MainDto, Gr2Main>(Purchasing.Main);
                main.ExcelServerRcid = Rcid;
                main.ExcelServerRtid = rtId;
                main.SupplierName = _pinhuaContext.往来单位.AsNoTracking().FirstOrDefault(p => p.单位编号 == main.Supplier).单位名称;

                var details = _mapper.Map<List<Gr2DetailsDto>, List<Gr2Details>>(Purchasing.Details);
                details.ForEach(i =>
                {
                    i.ExcelServerRcid = Rcid;
                    i.ExcelServerRtid = rtId;
                    i.PurchasingId = main.PurchasingId;
                });

                if (Purchasing.Details.Count == 0)
                {
                    ModelState.AddModelError("", "采购清单不可为空");
                    PurchasingTypes = buildPurchasingTypes();
                    SupplierList = _pinhuaContext.GetCustomerSelectList();
                    return Page();
                }
                _pinhuaContext.EsRepCase.Add(repCase);
                _pinhuaContext.Gr2Main.Add(main);
                _pinhuaContext.Gr2Details.AddRange(details);
                _pinhuaContext.SaveChanges();

                return RedirectToPage("Index");
            }
            else
            {
                PurchasingTypes = buildPurchasingTypes();
                SupplierList = _pinhuaContext.GetCustomerSelectList();
                return Page();
            }
        }

        private string buildPurchasingId()
        {
            _pinhuaContext.Database.OpenConnection();
            var cmd = _pinhuaContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandText = "SELECT dbo.GetPurchasingID('CG',GETDATE())";
            var result = cmd.ExecuteReader();
            var purchasingId = string.Empty;
            while (result.Read())
            {
                purchasingId = result[0].ToString();
            }
            return purchasingId;
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