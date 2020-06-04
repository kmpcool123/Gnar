using Gnar.Models;
using Microsoft.AspNet.Identity;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gnar.MVC.Controllers
{
    public class DeckController : Controller
    {
        [Authorize]
        // GET: Deck
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new DeckService(userId);
            var model = new DeckListItem[0];
            return View(model);
            
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DeckCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateDeckService();

            if(service.CreateDeck(model))
            {
                TempData["SaveResult"] = "Deck Made!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Deck could not be Made :(");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateDeckService();
            var model = svc.GetDeckById(id);

            return View(model);
        }

        private DeckService CreateDeckService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new DeckService(userId);
            return service;
        }

        
    }
}