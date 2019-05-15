﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<string> images = new List<string>();
            images.Add("https://static.flickr.com/66/199481236_dc98b5abb3_s.jpg");
            images.Add("https://static.flickr.com/75/199481072_b4a0d09597_s.jpg");
            images.Add("https://static.flickr.com/57/199481087_33ae73a8de_s.jpg");
            images.Add("https://static.flickr.com/77/199481108_4359e6b971_s.jpg");
            images.Add("https://static.flickr.com/58/199481143_3c148d9dd3_s.jpg");
            images.Add("https://static.flickr.com/72/199481203_ad4cdcf109_s.jpg");
            images.Add("https://static.flickr.com/58/199481218_264ce20da0_s.jpg");
            images.Add("https://static.flickr.com/69/199481255_fdfe885f87_s.jpg");
            images.Add("https://static.flickr.com/60/199480111_87d4cb3e38_s.jpg");
            images.Add("https://static.flickr.com/70/229228324_08223b70fa_s.jpg");

            return View(images);



            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
