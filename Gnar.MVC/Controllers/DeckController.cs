using Gnar.Models;
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
            var model = new DeckListItem[0];
            return View(model);
            
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }
    }
}