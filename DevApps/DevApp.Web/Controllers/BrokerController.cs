using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using DevApp.Web.Models;

using Tripous;
using Tripous.Data;
using Tripous.Model;

namespace DevApp.Web.Controllers
{
    /// <summary>
    /// Test controller
    /// </summary>
    [AllowAnonymous]
    public class BrokerController : BaseControllerMvc
    {
        /* actions */
        /// <summary>
        /// Action
        /// </summary>
        public IActionResult Initialize(string BrokerName)
        {
            JObject JO = new JObject();
            dynamic Data = JO;
            Data.ErrorText = "";
            Data.Result = false;
            try
            {
                SqlBroker broker = Broker.Create(BrokerName, true) as SqlBroker;
                JsonBroker Packet = broker.JsonInitialize();
                Data.Packet = JObject.FromObject(Packet);
                Data.Result = true;
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
        public IActionResult Insert(string BrokerName)
        {
            JObject JO = new JObject();
            dynamic Data = JO;
            Data.ErrorText = "";
            Data.Result = false;
            try
            {
                SqlBroker broker = Broker.Create(BrokerName, true) as SqlBroker;
                JsonBroker Packet = broker.JsonInsert();
                Data.Packet = JObject.FromObject(Packet);
                Data.Result = true;
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
        public IActionResult Edit(string BrokerName, string Id)
        {
            JObject JO = new JObject();
            dynamic Data = JO;
            Data.ErrorText = "";
            Data.Result = false;
            try
            {
                SqlBroker broker = Broker.Create(BrokerName, true) as SqlBroker;
                JsonBroker Packet = broker.JsonEdit(Id);
                Data.Packet = JObject.FromObject(Packet);
                Data.Result = true;
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
        public IActionResult Delete(string BrokerName, string Id)
        {
            JObject JO = new JObject();
            dynamic Data = JO;
            Data.ErrorText = "";
            Data.Result = false;
            try
            {
                SqlBroker broker = Broker.Create(BrokerName, true) as SqlBroker;
                broker.JsonDelete(Id);
                Data.Result = true;
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
        public IActionResult Commit([FromBody]JsonBroker Packet)
        {
            JObject JO = new JObject();
            dynamic Data = JO;
            Data.ErrorText = "";
            Data.Result = false;
            try
            {
                SqlBroker broker = Broker.Create(Packet.Name, true) as SqlBroker;
                Packet = broker.JsonCommit(Packet);
                Data.Packet = JObject.FromObject(Packet);
                Data.Result = true;
            }
            catch (Exception e)
            {
                Data.ErrorText = Sys.ExceptionText(e);
            }

            return this.Json(JO);
        }
        /// <summary>
        /// Action. The SqlText could be a SELECT statement or a SelectSql Name from
        /// the SelectList of the broker.
        /// </summary>
        public IActionResult SelectBrowser(string BrokerName, string SqlText, int RowLimit)
        {
            JObject JO = new JObject();
            dynamic Data = JO;
            Data.ErrorText = "";
            Data.Result = false;
            try
            {

                SqlBroker broker = Broker.Create(BrokerName, true) as SqlBroker;
                JsonDataTable Packet = broker.JsonSelectBrowser(SqlText, RowLimit);
                Packet.Name = "Browser";
                Data.Packet = JObject.FromObject(Packet);
                Data.Result = true;
            }
            catch (Exception e)
            {
                Data.ErrorText = Sys.ExceptionText(e);
            }

            return this.Json(JO);
        }


        /// <summary>
        ///  Returns an array of SelectSql items, those added by the application and those
        ///  added by the user at runtime
        /// </summary>
        public IActionResult GetMergedSelectSqlList(string BrokerName)
        {
            JObject JO = new JObject();
            dynamic Data = JO;
            Data.ErrorText = "";
            Data.Result = false;
            try
            {
                BrokerDescriptor Descriptor = Registry.Brokers.Find(BrokerName);
                SelectSql[] Packet = Descriptor.GetMergedSelectSqlList();

                JObject JList = new JObject();
                JArray A = new JArray();
                JList.Add("List", A);
                foreach (SelectSql SS in Packet)
                {
                    A.Add(JObject.FromObject(SS));
                }

                Data.Packet = JList;
                Data.Result = true;
            }
            catch (Exception e)
            {
                Data.ErrorText = Sys.ExceptionText(e);
            }

            return this.Json(JO);
        }
    }
}
