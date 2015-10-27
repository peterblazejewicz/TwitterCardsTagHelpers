using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;

namespace TwitterCardTagHelpers
{
    // You may need to install the Microsoft.AspNet.Razor.Runtime package into your project
    [HtmlTargetElement("twitter-card")]
    public class TwitterCardTagHelper : TagHelper
    {
        [HtmlAttributeName("type")]
        public string type { get; set; }

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
            output.TagName = null;
        }
    }
}
