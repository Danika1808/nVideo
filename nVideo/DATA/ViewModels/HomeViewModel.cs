﻿using nVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nVideo.DATA.ViewModels
{
    public class HomeViewModel
    {
        // 3 items
        public IEnumerable<Catalog_Entity> ForCarousel { get; set; }
        //8 items
        public IEnumerable<Catalog_Entity> ForNewProductsBlock { get; set; }
        //3 items
        public IEnumerable<Catalog_Entity> ForThumbnailBlock { get; set; }
        //3 items
        public IEnumerable<Catalog_Entity> ForFeaturedBlock { get; set; }
    }
}
