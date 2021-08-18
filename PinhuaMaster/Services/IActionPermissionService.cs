using System.Collections.Generic;
using PinhuaMaster.Data;

namespace PinhuaMaster.Services
{
    public interface IActionPermissionService
    {
        IEnumerable<ApplicationPermission> GetAllPermissions();
    }
}