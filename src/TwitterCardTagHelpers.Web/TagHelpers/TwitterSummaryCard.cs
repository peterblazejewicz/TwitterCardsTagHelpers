using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Mvc.Rendering;

namespace TwitterCardTagHelpers.Web.TagHelpers
{
    // You may need to install the Microsoft.AspNet.Razor.Runtime package into your project
    [HtmlTargetElement("twitter-summary", Attributes = SiteAttributeName)]
    [HtmlTargetElement("twitter-summary", Attributes = TitleAttributeName)]
    [HtmlTargetElement("twitter-summary", Attributes = DescriptionAttributeName)]
    [HtmlTargetElement("twitter-summary", Attributes = ImageAttributeName)]
    public class TwitterSummaryCard : TagHelper
    {

        private const string SiteAttributeName = "site";
        private const string TitleAttributeName = "title";
        private const string DescriptionAttributeName = "description";
        private const string ImageAttributeName = "image";

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
            output.PostContent.Append(GenerateMetaTag(new Dictionary<string, string>()
            {
                ["name"] = "twitter:card",
                ["content"] = "summary"
            }));
            if (site != null)
            {
                output.PostContent.Append(GenerateMetaTag(new Dictionary<string, string>()
                {
                    ["name"] = "twitter:site",
                    ["content"] = site
                }));
            }
            if (title != null)
            {
                output.PostContent.Append(GenerateMetaTag(new Dictionary<string, string>()
                {
                    ["name"] = "twitter:title",
                    ["content"] = title
                }));
            }
            if (description != null)
            {
                output.PostContent.Append(GenerateMetaTag(new Dictionary<string, string>()
                {
                    ["name"] = "twitter:description",
                    ["content"] = description
                }));
            }
            if (image != null)
            {
                output.PostContent.Append(GenerateMetaTag(new Dictionary<string, string>()
                {
                    ["name"] = "twitter:image",
                    ["content"] = image
                }));
            }


        }

        private TagBuilder GenerateMetaTag(IDictionary<string, string> attrs)
        {
            var tb = new TagBuilder("meta");
            tb.TagRenderMode = TagRenderMode.SelfClosing;
            tb.MergeAttributes<string, string>(attrs);
            return tb;
        }
    }
}
