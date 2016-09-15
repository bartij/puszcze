using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjektPuszcze.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ProjektPuszcze.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dzialalnosc()
        {
            return View();
        }
    }
}