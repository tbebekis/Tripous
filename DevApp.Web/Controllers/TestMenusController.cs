using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using DevApp.Web.Models;

namespace DevApp.Web.Controllers
{
    /// <summary>
    /// A test controller
    /// </summary>
    [AllowAnonymous]
    public class TestMenusController : BaseAppController
    {
        /* actions */
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult Menu()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult ContextMenu()
        {
            return View();
        }

        /// <summary>
        /// Test
        /// </summary>
        public IActionResult SiteMenu()
        {
            return View();
        }
        /// <summary>
        /// Test
        public IActionResult ToolBar()
        {
            return View();
        }
    }
}
