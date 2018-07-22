using Microsoft.AspNetCore.Mvc;
using Road.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Road.Controllers
{
    public class RoadController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetPlayer(int id)
        {
            var player = PlayerManager.GetPlayer(id);
            HttpContext.Session.Set("player" , player);

        }
    }
}
