﻿using System.Collections.Generic;
using Dit.Umb.ToolBox.Models.PoCo;
using Umbraco.Core.Models.PublishedContent;

namespace Dit.Umb.ToolBox.Models.PageModels
{
    public class ContentPage : ArticlePage
    {
        public IEnumerable<MutoboContentModule> Modules { get; set; }

        public ContentPage(IPublishedContent content) : base(content)
        {
        }
    }
}
