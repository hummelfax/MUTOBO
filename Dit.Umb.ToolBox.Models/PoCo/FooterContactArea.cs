﻿using Dit.Umb.ToolBox.Models.Constants;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Dit.Umb.ToolBox.Models.PoCo
{
    public class FooterContactArea : PublishedElementModel
    {
        public string Headline { get; set; }
        public string AddressBlock { get; set; }

        public FooterContactArea(IPublishedElement content) : base(content)
        {
            Headline = content.HasValue(DocumentTypes.FooterContact.Headline) ? content.Value<string>(DocumentTypes.FooterContact.Headline) : string.Empty;
            AddressBlock = content.HasValue(DocumentTypes.FooterContact.AddressBlock) ? content.Value<string>(DocumentTypes.FooterContact.AddressBlock) : string.Empty;
        }
    }
}
