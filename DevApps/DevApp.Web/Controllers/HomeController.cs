using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization; 

using Newtonsoft.Json;
using Newtonsoft.Json.Linq; 

using Tripous;
using Tripous.Data;
using Tripous.Model;
using Tripous.Web;

using DevApp.Web.Models;

namespace DevApp.Web.Controllers
{
    public class HomeController : BaseControllerMvc
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
   

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SetLanguage(string LanguageCode)
        {
            LanguageItem Lang = Languages.Find(LanguageCode);
            if (Lang != null && Lang.CultureCode != Session.Language.CultureCode)
            {
                Session.Language = Lang;
            }
            
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

            HttpErrorInfo EI = new HttpErrorInfo(this.HttpContext);
            Sys.LogError(EI.ToString());
            return View(EI);
        }

 
    }
}
