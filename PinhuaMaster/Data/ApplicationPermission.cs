using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinhuaMaster.Data
{
    public class ApplicationPermission
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// RazorPage名
        /// </summary>
        public string Page { get; set; }
        /// <summary>
        /// 控制器名
        /// </summary>
        public string Controller { get; set; }
        /// <summary>
        /// 方法名
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// 参数字符串
        /// </summary>
        public string Params { get; set; }
        /// <summary>
        /// 功能描述
        /// </summary>
        public string Description { get; set; }

    }

    public class ApplicationRolePage
    {
        public virtual string RoleId { get; set; }
        public virtual string Page { get; set; }
    }
}
