using Gnar.Models.TrucksModel;
using Microsoft.AspNet.Identity;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gnar.MVC.Controllers
{
    public class TrucksController : Controller
    {
        [Authorize]
        // GET: Trucks
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TrucksService(userId);
            var model = new TrucksListItem[0];
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TrucksCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateTrucksService();

            if (service.CreateTrucks(model))
            {
                TempData["SaveResult"] = "Trucks Made!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Trucks could not be Made :(");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateTrucksService();
            var model = svc.GetTrucksById(id);

            return View(model);
        }

        private TrucksService CreateTrucksService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TrucksService(userId);
            return service;
        }

        public ActionResult Edit(int id)
        {
            var service = CreateTrucksService();
            var detail = service.GetTrucksById(id);
            var model =
                new TrucksEdit
                {
                    TruckId = detail.TruckId,
                    TruckName = detail.TruckName,
                    Weight = detail.Weight,
                    Brand = detail.Brand,
                    ProModel = detail.ProModel,
                    Size = detail.Size,
                    Color = detail.Color,
                    

                    ModifiedUtc = detail.ModifiedUtc
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TrucksEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.TruckId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateTrucksService();

            if (service.UpdateTrucks(model))
            {
                TempData["SaveResult"] = "Your Trucks has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your Trucks couldn't be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateTrucksService();
            var model = svc.GetTrucksById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteDeck(int id)
        {
            var service = CreateTrucksService();

            service.DeleteTrucks(id);

            TempData["SaveResult"] = "Your Trucks have been deleted";

            return RedirectToAction("Index");
        }
    }
}