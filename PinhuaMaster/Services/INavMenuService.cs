using System.Collections.Generic;
using PinhuaMaster.Data;

namespace PinhuaMaster.Services
{
    public interface INavMenuService
    {
        IList<NavbarMenu> GetNavbarMenus();
        void UpdateNavbarMenus(string navbarMenus);
        IList<string> GetPathName(string pagePath);
    }
}