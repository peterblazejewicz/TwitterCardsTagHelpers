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
            var typeTag = CreateTagBuilder(new Dictionary<string, string>()
            {
                ["name"] = "twitter:card",
                ["content"] = card
            });
            output.PostContent.Append(typeTag);
            if (site != null)
            {
                var siteTag = CreateTagBuilder(new Dictionary<string, string>()
                {
                    ["name"] = "twitter:site",
                    ["content"] = site
                });
                output.PostContent.Append(siteTag);
            }
            if (title != null)
            {
                var titleTag = CreateTagBuilder(new Dictionary<string, string>()
                {
                    ["name"] = "twitter:title",
                    ["content"] = title
                });
                output.PostContent.Append(titleTag);
            }
            if (description != null)
            {
                var descriptionTag = CreateTagBuilder(new Dictionary<string, string>()
                {
                    ["name"] = "twitter:description",
                    ["content"] = description
                });
                output.PostContent.Append(descriptionTag);
            }
            if (image != null)
            {
                var imageTag = CreateTagBuilder(new Dictionary<string, string>()
                {
                    ["name"] = "twitter:image",
                    ["content"] = image
                });
                output.PostContent.Append(imageTag);
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
