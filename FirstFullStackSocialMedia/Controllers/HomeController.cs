﻿using FirstFullStackSocialMedia.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace FirstFullStackSocialMedia.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var upcomingGigs = _dbContext.Gigs
                               .Include(g => g.Artist)
                               .Include(g => g.Genre)
                               .Where(g => g.DateTime > DateTime.Now);
            return View(upcomingGigs);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}