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
    public class TestControlsController : BaseAppController
    {

        /* actions */
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult AutocompleteList()
        {
            return View();
        }
        /// <summary>
        /// For testing the tp.AutocompleteList javascript class
        /// </summary>
        public IActionResult GetAutocompleteList(string Text, bool UseStartsWith)
        {
            int Id = 1;
            string[] A = { "html5", "javascript", "typescript", "script", "scriptable", "html", "css rules", "responsive", "restfull" };

            object List = A.Where(S => UseStartsWith ? S.StartsWith(Text, StringComparison.OrdinalIgnoreCase) : S.IndexOf(Text, StringComparison.OrdinalIgnoreCase) >= 0).
                Select(S => new { Id = Id++, Name = S }).ToArray();


            object Data = new
            {
                ErrorText = "",
                Result = true,
                List = List,
            };

            IActionResult Result = Json(Data);
            return Result;

        }


        /// <summary>
        /// Test
        /// </summary>
        public IActionResult Label()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult TextBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult Memo()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult CheckBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult NumberBox()
        {
            return View();
        }

        /// <summary>
        /// Test
        /// </summary>
        public IActionResult ComboBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult ListBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult CheckListBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult CheckComboBox()
        {
            return View();
        }

        /// <summary>
        /// Test
        /// </summary>
        public IActionResult HtmlComboBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult HtmlListBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult HtmlNumberBox()
        {
            return View();
        }

        /// <summary>
        /// Test
        /// </summary>
        public IActionResult Calendar()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult DateBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult ImageBox()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult RadioGroup()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult ValueSlider()
        {
            return View();
        }

        /// <summary>
        /// Test
        /// </summary>
        public IActionResult ProgressBar()
        {
            return View();
        }
        /// <summary>
        /// Test
        /// </summary>
        public IActionResult TreeView()
        {
            return View();
        }
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
