using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;
using PinhuaMaster.Data;
using PinhuaMaster.Extensions;
using PinhuaMaster.Services;

namespace PinhuaMaster.Pages.MenuSystem
{
    public class IndexModel : PageModel
    {
        public IndexModel(ApplicationDbContext dbContext, INavMenuService navMenuService, IFileProvider fileProvider, IOptionsSnapshot<List<NavbarMenu>> navbarMenus)
        {
            _dbContext = dbContext;
            _navMenuService = navMenuService;
            _fileProvider = fileProvider;
            _navbarMenus = navbarMenus;
        }

        public ApplicationDbContext _dbContext { get; set; }

        public INavMenuService _navMenuService { get; set; }

        public IFileProvider _fileProvider { get; set; }

        //[BindProperty]
        //public IEnumerable<Menu> _menus { get; set; }

        public IOptionsSnapshot<List<NavbarMenu>> _navbarMenus { get; set; }

        public void OnGet()
        {
            //_menus = _dbContext.Menus.AsNoTracking();
            //ViewData["NavMenuManagementData"] = _navbarMenus.Value;
        }

        public IActionResult OnPostDelete(string id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _dbContext.Menus.Remove(_dbContext.Menus.Find(id));
                    _dbContext.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_dbContext.Menus.Any(x => x.Id == id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //_navMenuService.InitOrUpdate();
            }

            //_menus = _dbContext.Menus.AsNoTracking();

            return RedirectToPage("Index"); 
        }

        public IActionResult OnPostSaveMenu(string navMenuJson)
        {
            if (!string.IsNullOrEmpty(navMenuJson))
                _navMenuService.UpdateNavbarMenus(navMenuJson);

            return RedirectToPage("Index");
        }

        /// <summary>
        /// 初始化下拉选择框
        /// </summary>
        /// <param name="menu"></param>
        private void UpdateDropDownList(Menu menu = null)
        {
            var menusParent = _dbContext.Menus.AsNoTracking().Where(s => s.MenuType == MenuTypes.导航菜单);
            List<SelectListItem> listMenusParent = new List<SelectListItem>();
            foreach (var menuParent in menusParent)
            {
                listMenusParent.Add(new SelectListItem
                {
                    Value = menuParent.Id,
                    Text = menuParent.Id + $"({menuParent.Name})",
                    Selected = (menu != null && menuParent.Id == menu.ParentId)
                });
            }
            ViewData["ParentIds"] = listMenusParent;

            if (menu == null)
            {
                ViewData["MenuTypes"] = MenuTypes.导航菜单.GetSelectListByEnum();
            }
            else
            {
                ViewData["MenuTypes"] = MenuTypes.导航菜单.GetSelectListByEnum(Convert.ToInt32(menu.MenuType));
            }
        }
    }
}