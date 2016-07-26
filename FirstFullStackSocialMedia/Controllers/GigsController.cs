﻿using FirstFullStackSocialMedia.Models;
using FirstFullStackSocialMedia.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace FirstFullStackSocialMedia.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel()
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}