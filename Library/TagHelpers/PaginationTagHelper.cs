﻿using Library.Utility;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Library.TagHelpers
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PaginationTagHelper : TagHelper
    {
        public PaginationDetails PageModel { get; set; }

        public string PageClass { get; set; }

        public string PageClassNormal { get; set; }

        public string PageClassSelected { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var divTagBuilder = new TagBuilder("div");

            for (var i = 1; i <= PageModel.TotalPages; i++)
            {
                var aTag = new TagBuilder("a");
                var url = $"{PageModel.Url}?pageNumber={i}";
                aTag.Attributes["href"] = url;
                aTag.AddCssClass(PageClass);

                aTag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal);
                aTag.InnerHtml.Append(i.ToString());

                divTagBuilder.InnerHtml.AppendHtml(aTag);
            }

            output.Content.AppendHtml(divTagBuilder.InnerHtml);

        }
    }
}
