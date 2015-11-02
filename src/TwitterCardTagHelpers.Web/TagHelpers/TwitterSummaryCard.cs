using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Mvc.Rendering;

namespace TwitterCardTagHelpers.Web.TagHelpers
{
    // You may need to install the Microsoft.AspNet.Razor.Runtime package into your project
    [HtmlTargetElement("twitter-summary")]

    public class TwitterSummaryCard : TagHelper
    {

        [HtmlAttributeName("site")]
        public string site { get; set; }

        [HtmlAttributeName("title")]
        public string title { get; set; }

        [HtmlAttributeName("description")]
        public string description { get; set; }

        [HtmlAttributeName("image")]
        public string image { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }
        }

        private void GenerateMetaTag(TagHelperOutput output, string key, string value)
        {
            var tb = new TagBuilder("meta");
            tb.TagRenderMode = TagRenderMode.SelfClosing;
            tb.MergeAttribute(key, value);
            output.PostContent.Append(tb);
        }
    }
}
