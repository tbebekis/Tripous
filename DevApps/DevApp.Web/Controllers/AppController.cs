using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using DevApp.Web.Models;

using Tripous;
using Tripous.Data;
using Tripous.Model;
using Tripous.Web;

namespace DevApp.Web.Controllers
{
    /// <summary>
    /// Test controller
    /// </summary>
    [AllowAnonymous]
    public class AppController : BaseAppController
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Test()
        {
             
            JObject JPacket = new JObject();
            dynamic DynPacket = JPacket;
            JArray JItems = new JArray();
            JPacket.Add("Items", JItems);

            DynPacket.LanguageCode = Session.LanguageCode;
            DynPacket.Flag = true;
            DynPacket.Date = DateTime.Now;

            for (int i = 0; i < 5; i++)
                JItems.Add(i);

            HttpActionResult Result = new HttpActionResult();
            Result.SerializePacket(JPacket);
            Result.IsSuccess = true;

            return this.Json(Result);
        }

        [HttpGet] 
        public JsonResult Culture()
        { 
            HttpActionResult Result = new HttpActionResult();
            Result.Packet = Session.LanguageCode;
            Result.IsSuccess = true;

            return this.Json(Result);
        }
        [HttpPost]
        public JsonResult Culture(string LanguageCode)
        {
            HttpActionResult SimpleResult = new HttpActionResult();
            Session.LanguageCode = LanguageCode;
            SimpleResult.IsSuccess = true;
            return this.Json(SimpleResult);
        }

        /// <summary>
        /// Action
        /// </summary>
        public JsonResult GetRegistryList(string ListName)
        {
            JObject JO = new JObject();
            dynamic Data = JO;
            Data.ErrorText = "";
            Data.Result = false;
            string JsonText;

            JObject JPacket = null;
            JArray JItems = null;
            JObject JItem = null;

            try
            {
                JPacket = new JObject();
                JItems = new JArray();
                JPacket.Add("Items", JItems);

                if ("Locators".IsSameText(ListName))
                {
                    foreach (LocatorDescriptor Descriptor in Registry.Locators)
                    {
                        JsonText = this.ToJson(Descriptor);
                        JItem = JObject.Parse(JsonText);
                        JItems.Add(JItem);
                    }
                }
                else
                {
                    JPacket = null;
                }

                if (JPacket != null)
                {
                    Data.Packet = JPacket;
                    Data.Result = true;
                }
                else
                {
                    Data.ErrorText = string.Format("Registry list not found. ListName: {0}", ListName);
                }


            }
            catch (Exception e)
            {
                Data.ErrorText = Sys.ExceptionText(e);
            }

            return this.Json(JO);
        }
        /// <summary>
        /// Action
        /// </summary>
        public JsonResult GetRegistryItem(string ItemType, string ItemName)
        {
            JObject JO = new JObject();
            dynamic Data = JO;
            Data.ErrorText = "";
            Data.Result = false;
            string JsonText;
            JObject Packet = null;
            try
            {
                if ("Locator".IsSameText(ItemType))
                {
                    LocatorDescriptor Descriptor = Registry.Locators.Find(ItemName);
                    if (Descriptor != null)
                    {
                        JsonText = this.ToJson(Descriptor);
                        Packet = JObject.Parse(JsonText);
                    }
                }

                if (Packet != null)
                {
                    Data.Packet = Packet;
                    Data.Result = true;
                }
                else
                {
                    Data.ErrorText = string.Format("Registry item not found. ItemType: {0}, ItemName: {1}", ItemType, ItemName);
                }


            }
            catch (Exception e)
            {
                Data.ErrorText = Sys.ExceptionText(e);
            }

            return this.Json(JO);
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
