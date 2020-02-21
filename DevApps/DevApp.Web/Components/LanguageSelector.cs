using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using Tripous.Web;


namespace DevApp.Web.Components
{

    /// <summary>
    /// Language selector view component
    /// </summary>
    public class LanguageSelector : ViewComponent
    {
        /// <summary>
        /// Invokes the component and returns a view
        /// </summary>
        public IViewComponentResult Invoke()
        {
            var List = WApp.LanguageItems;
            return View(List);
        }
    }
}
