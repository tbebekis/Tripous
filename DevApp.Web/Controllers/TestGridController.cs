using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
 
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using DevApp.Web.Models;

namespace DevApp.Web.Controllers
{
    [AllowAnonymous]
    public class TestGridController : BaseAppController
    {

        /* actions */ 
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult Grid()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult Grid2()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult Grid3()
        {
            return View();
        }
    }
}
