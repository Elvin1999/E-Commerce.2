using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace E_Commerce.WebUI.TagHelpers
{
    [HtmlTargetElement("product-list-pager")]
    public class PagingTagHelper:TagHelper
    {
        [HtmlAttributeName("page-size")]
        public int PageSize { get; set; }
        [HtmlAttributeName("page-count")]
        public int PageCount { get; set; }
        [HtmlAttributeName("current-category")]
        public int CurrentCategory { get; set; }
        [HtmlAttributeName("current-page")]
        public int CurrentPage { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var sb = new StringBuilder();
            sb.Append("<ul class='pagination' >");
            for (int i = 1; i <=PageCount; i++)
            {
                sb.AppendFormat("<li class='{0}'", i == CurrentPage ? "active" : "");
                sb.AppendFormat("<a href='/product/index?page={0}&category{1}'>{2}</a>",
                    i,CurrentCategory,i);
                sb.Append("</li>");
            }
            output.Content.SetHtmlContent(sb.ToString());

        }
    }
}
