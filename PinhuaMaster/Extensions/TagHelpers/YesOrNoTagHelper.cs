using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TagHelpers
{
    [HtmlTargetElement("zky-tag-yesno")]
    public class YesColorTagHelper : TagHelper
    {
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.AspNetCore.Mvc.Rendering.ViewContext" /> for the current request.
        /// </summary>
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public string Description { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            output.TagName = "span";
            output.TagMode = TagMode.StartTagAndEndTag;
            var content = HttpUtility.HtmlDecode(output.GetChildContentAsync().GetAwaiter().GetResult().GetContent());
            if (content == "是" || content == "Yes")
            {
                output.Attributes.SetAttribute("class", "text-primary");
                output.Content.SetContent($"{content}，{Description}");
            }
            else
            {
                output.Attributes.SetAttribute("class", "text-danger");
            }
        }

    }

    [HtmlTargetElement(Attributes = "zky-yesno")]
    public class YesOrNoTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            var content = output.GetChildContentAsync().GetAwaiter().GetResult().GetContent();
            if (content.ToLower() == "yes")
            {
                output.Attributes.SetAttribute("class", "text-primary");
            }
            else
            {
                output.Attributes.SetAttribute("class", "text-danger");
            }
        }
    }
}