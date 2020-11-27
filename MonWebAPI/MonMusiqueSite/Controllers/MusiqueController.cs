using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonMusiqueSite.Controllers
{
    public class MusiqueController : Controller
    {
        // GET: Musique
        public ActionResult MusiqueListe()
        {
            return View();
        }
    }
}