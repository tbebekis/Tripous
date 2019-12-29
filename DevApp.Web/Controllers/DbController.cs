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

    [AllowAnonymous]
    public class DbController : BaseAppController
    {


        DataTable SelectTable(string SqlText, string ConnectionName)
        {
            SqlStore Store = SqlStores.CreateSqlStore(ConnectionName);
 
            DataTable Table = Store.Select(SqlText);
            return Table;
        }


        /* actions */
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Select(string SqlText, string ConnectionName)
        {
            JObject JO = new JObject();
            dynamic Data = JO;
            Data.ErrorText = "";
            Data.Result = false;
            try
            {
                DataTable Table = SelectTable(SqlText, ConnectionName);
                JsonDataTable JTable = new JsonDataTable(Table);

                Data.Packet = JTable.ToJObject(); // Table.ToJsonProxy();
                Data.Result = true;
            }
            catch (Exception e)
            {
                Data.ErrorText = Sys.ExceptionText(e);
            }

            return this.Json(JO);
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult SelectAll(JsonDataTable JTable)
        {
            JObject JO = new JObject();
            dynamic Data = JO;
            Data.ErrorText = "";
            Data.Result = false;
            try
            {

                string Name, SqlText, ConnectionName;
                JsonDataSet JDataSet = new JsonDataSet();

                DataTable Table;
                DataTable tblSqlList = JTable.ToTable();
                foreach (DataRow Row in tblSqlList.Rows)
                {
                    Name = Row.AsString("Name");
                    ConnectionName = Row.AsString("ConnectionName");
                    SqlText = Row.AsString("SqlText");

                    Table = SelectTable(SqlText, ConnectionName);
                    Table.TableName = Name;
                    JTable = new JsonDataTable(Table, null);
                    JDataSet.Tables.Add(JTable);
                }

                Data.Packet = JDataSet.ToJObject();
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
