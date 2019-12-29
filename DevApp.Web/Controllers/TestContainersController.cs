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
    /// Test controller
    /// </summary>
    [AllowAnonymous]
    public class TestContainersController: BaseAppController
    {
        /* actions */
        /// <summary>
        /// Test
        /// </summary>        
        public IActionResult DropDownBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult VirtualScroller()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult Splitter()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult GroupBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult Accordion()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult TabControl()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult PanelList()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult ImageSlider()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult IFrame()
        {
            return View();
        }

    }
}
