﻿using Dit.Umb.ToolBox.Models.PoCo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dit.Umb.ToolBox.Models.Constants;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Dit.Umb.ToolBox.Models.Configuration
{
    public class FooterConfiguration : PublishedElementModel
    {
        public IEnumerable<FooterNavBlock> FooterNavBlocks { get; set; }

        public IEnumerable<Umbraco.Web.Models.Link> FooterLinks =>
            this.Value<IEnumerable<Umbraco.Web.Models.Link>>(DocumentTypes.FooterConfiguration.Fields.Links);

        public IEnumerable<FooterContactArea> FooterContactBlock { get; set; }

        public IEnumerable<Language> Languages { get; set; }


        public IEnumerable<PictureLink> PictureLinks { get; set; }

        public string Copyright => $"&copy; {DateTime.Today.Year} {this.Value<string>(DocumentTypes.FooterConfiguration.Fields.CopyRight)}" ;

        public FooterConfiguration(IPublishedElement content) : base(content)
        {
        }
    }
}
