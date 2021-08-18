using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PinhuaMaster.Data
{
    /// <summary>
    /// 菜单
    /// </summary>
    public class Icon
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "请输入图标编号")]
        public string Id { get; set; }

        /// <summary>
        /// 图标名称
        /// </summary>
        [Required(ErrorMessage = "请输入图标名称")]
        public string Name { get; set; }

        /// <summary>
        /// 图标类名
        /// </summary>
        [Required(ErrorMessage = "请输入图标类名")]
        public string ClassName { get; set; }

        /// <summary>
        /// 图标来源
        /// </summary>
        [Required(ErrorMessage = "请选择图标来源")]
        public SourceTypes SourceType { get; set; }

    }

    /// <summary>
    /// 菜单类型
    /// </summary>
    public enum SourceTypes
    {
        /// <summary>
        /// Glyphicons 字体图标
        /// </summary>
        Glyphicons,
        /// <summary>
        /// Fontawesome 字体图标
        /// </summary>
        Fontawesome
    }
}
