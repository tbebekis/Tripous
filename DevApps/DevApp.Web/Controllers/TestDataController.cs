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

    /// <summary>
    /// Test controller
    /// </summary>
    [AllowAnonymous]
    public class TestDataController : BaseControllerMvc
    {        
        /* actions */
        /// <summary>
             /// Test
             /// </summary>
        public IActionResult SimpleBinding()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult ListBinding()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult MasterDetail()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult DataView()
        {
            return View();
        }

        /// <summary>
        /// Test
        /// </summary>
        public IActionResult Locator()
        {
            return View();
        }
    }
}
