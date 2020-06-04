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

        public ActionResult Edit(int id)
        {
            var service = CreateDeckService();
            var detail = service.GetDeckById(id);
            var model =
                new DeckEdit
                {
                    DeckId = detail.DeckId,
                    DeckName = detail.DeckName,
                    Shape = detail.Shape,
                    Brand = detail.Brand,
                    ProModel = detail.ProModel,
                    Size = detail.Size,
                    Color = detail.Color,
                    WheelBase = detail.WheelBase,
                    
                    ModifiedUtc =detail.ModifiedUtc
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, DeckEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.DeckId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateDeckService();

            if (service.UpdateDeck(model))
            {
                TempData["SaveResult"] = "Your Deck has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your note could not be updated.");
            return View(model);
        }
    }
}