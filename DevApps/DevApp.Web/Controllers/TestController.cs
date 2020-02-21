using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Tripous;

using DevApp.Web.Models;

namespace DevApp.Web.Controllers
{
    /// <summary>
    /// A test controller
    /// </summary>
    [AllowAnonymous]
    public class TestController : BaseControllerMvc
    {

        /* actions */
        /// <summary>
        /// Test
        /// </summary>        
        public IActionResult EmptyTest()
        {
            //Sys.Error("That's a big mistake");
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult TabIndexAndFocus()
        {
            return View();
        }


    }
}
