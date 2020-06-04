using Gnar.Models.BearingsModel;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gnar.MVC.Controllers
{
    public class BearingsController : Controller
    {
        [Authorize]
        // GET: Deck
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new BearingsService(userId);
            var model = service.GetBearings();
            return View(model);

        }

        //GET
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BearingsCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateBearingsService();

            if (service.CreateBearings(model))
            {
                TempData["SaveResult"] = "Bearings Made!";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Bearings could not be Made :(");

            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateDeckService();
            var model = svc.GetDeckById(id);

            return View(model);
        }

        private BearingsService CreateBearingsService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new BearingsService(userId);
            return service;
        }

        public ActionResult Edit(int id)
        {
            var service = CreateBearingsService();
            var detail = service.GetBearingsById(id);
            var model =
                new BearingsEdit
                {
                    BearingId = detail.BearingId,
                    BearingName = detail.BearingName,
                    AbecRating = detail.AbecRating,
                    Brand = detail.Brand,
                    ProModel = detail.ProModel,
                    Type = detail.Type,
                    Color = detail.Color,
                    

                    ModifiedUtc = detail.ModifiedUtc
                };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BearingsEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.BearingId != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }

            var service = CreateBearingsService();

            if (service.UpdateBearings(model))
            {
                TempData["SaveResult"] = "Your Bearings have been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Your Bearings couldn't be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateBearingsService();
            var model = svc.GetBearingsById(id);

            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteBearings(int id)
        {
            var service = CreateBearingsService();

            service.DeleteBearings(id);

            TempData["SaveResult"] = "Your Bearings have been deleted";

            return RedirectToAction("Index");
        }
    }
}
