﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dit.Umb.ToolBox.Models.Constants;
using Dit.Umb.ToolBox.Models.PoCo;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace Dit.Umb.ToolBox.Services.Impl
{
    public class PictureLinkService : BaseService, IPictureLinkService
    {
        private readonly IImageService _imageService;


        public PictureLinkService(IImageService imageService)
        {
            _imageService = imageService;
        }



        public IEnumerable<PictureLink> GetPictureLinks(IEnumerable<IPublishedElement> elements)
        {
            return elements.Select(e => new PictureLink(e)
            {
                Image = e.HasValue(DocumentTypes.PictureLink.Fields.Image) ? 
                    _imageService.GetImage(e.Value<IPublishedContent>(DocumentTypes.PictureLink.Fields.Image), 
                        width: 200, height: 50) 
                    : null
            });
        }
    }
}
