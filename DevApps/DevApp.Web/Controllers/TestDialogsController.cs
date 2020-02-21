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
    public class TestDialogsController: BaseControllerMvc
    {

        /* actions */ 
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult Notifications()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult NotificationDialogs()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult FrameBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult ContentWindow()
        {
            return View();
        }


        /// <summary>
        /// Test
        /// </summary>
        public IActionResult DataSetBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult TableBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult RowBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult PickRowsBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult PickRowBox()
        {
            return View();
        }


        /// <summary>
        /// Test
        /// </summary>
        public IActionResult MiscDialogs()
        {
            return View();
        }
        
    }
}