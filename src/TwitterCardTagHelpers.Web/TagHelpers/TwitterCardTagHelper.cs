using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Mvc.Rendering;

namespace TwitterCardTagHelpers.Web.TagHelpers
{
    // You may need to install the Microsoft.AspNet.Razor.Runtime package into your project
    [HtmlTargetElement("twitter-card")]
    public class TwitterCardTagHelper : TagHelper
    {
        [HtmlAttributeName("card")]
        public string card { get; set; }

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
            output.TagName = null;
            if (card == null)
            {
                card = "summary";
            }
            output.PostContent.Append(CreateTagBuilder(new Dictionary<string, string>()
            {
                ["name"] = "twitter:site",
                ["card"] = "summary"
            }));
            if (site != null)
            {
                output.PostContent.Append(CreateTagBuilder(new Dictionary<string, string>()
                {
                    ["name"] = "twitter:site",
                    ["content"] = site
                }));
            }
            if (title != null)
            {
                output.PostContent.Append(CreateTagBuilder(new Dictionary<string, string>()
                {
                    ["name"] = "twitter:title",
                    ["content"] = title
                }));
            }
            if (description != null)
            {
                output.PostContent.Append(CreateTagBuilder(new Dictionary<string, string>()
                {
                    ["name"] = "twitter:description",
                    ["content"] = description
                }));
            }
            if (image != null)
            {
                output.PostContent.Append(CreateTagBuilder(new Dictionary<string, string>()
                {
                    ["name"] = "twitter:image",
                    ["content"] = image
                }));
            }
        }

        private TagBuilder CreateTagBuilder(IDictionary<string, string> attrs)
        {
            var tb = new TagBuilder("meta");
            tb.TagRenderMode = TagRenderMode.SelfClosing;
            tb.MergeAttributes<string, string>(attrs);
            return tb;
        }
    }
}
