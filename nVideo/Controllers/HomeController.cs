﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nVideo.DATA.Interfaces;
using nVideo.Models;
using nVideo.DATA.ViewModels;

namespace nVideo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAllCatalog _catalog;

        private IEnumerable<Catalog_Entity> GetThridRandom{
            get{
                var rand = new List<Catalog_Entity>();
                for (int i = 0; i < 3; i++)
                    rand.Add(_catalog.GetRandomItem);

                return rand;
            }
        }

        public HomeController(ILogger<HomeController> logger, IAllCatalog catalog){
            _logger = logger;
            _catalog = catalog;
        }

        public IActionResult Index(){
            var model = new HomeViewModel();

            model.ForCarousel = _catalog.GetCarouselItems;
            model.ForFeaturedBlock = _catalog.GetFeaturedItems;
            model.ForNewProductsBlock = _catalog.GetNewItems;
            model.ForThumbnailBlock = GetThridRandom;

            return View(model);
        }      

        public IActionResult Privacy(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(){
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
