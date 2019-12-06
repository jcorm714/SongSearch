using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebServiceFinal.Models;

namespace WebServiceFinal.Controllers
{
    public class HomeController : Controller
    {
        private struct Options
        {
            public const string client_id = "1f6d12d8f0c8489db2623ad1ad05f8ec";
            public const string redirect_uri = "https://localhost:5001/Home/Callback/";
            public const string scopes = "streaming user-modify-playback-state user-read-email";
        }
        public IActionResult Index()
        {
            
            ViewData["client_id"] = Options.client_id;
            ViewData["redirect_uri"] = Options.redirect_uri;
            ViewData["scopes"] = Options.scopes;
            return View();
        }

        
        public IActionResult Callback()
        {
            
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
