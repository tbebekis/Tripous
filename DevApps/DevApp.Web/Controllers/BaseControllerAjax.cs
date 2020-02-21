using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using DevApp.Web.Models;

namespace DevApp.Web.Controllers
{

    /// <summary>
    /// Base Ajax (Api) controller
    /// </summary>
    public class BaseControllerAjax: ControllerBase
    {
        /// <summary>
        /// Converts Instance to a json string using the NewtonSoft json serializer.
        /// <para>If no settings specified then it uses the default JsonSerializerSettings</para> 
        /// </summary>
        public string ToJson(object Instance, JsonSerializerSettings Settings = null)
        {
            return Tripous.Json.ToJson(Instance, Settings);
        }
        /// <summary>
        /// Converts a specified Instance to json text.
        /// <para> ExcludeProperties, if not null, may contain property names to be ignored</para>
        /// </summary>
        public string ToJson(object Instance, string[] ExcludeProperties)
        {
            return Tripous.Json.ToJson(Instance, ExcludeProperties);
        }

        /// <summary>
        /// Creates a <see cref="Microsoft.AspNetCore.Mvc.JsonResult" /> object that serializes the specified data object to JSON.
        /// </summary>
        public JsonResult Json(object data)
        {
            return new JsonResult(data);
        }

        /* properties */
        /// <summary>
        /// Returns true if the user is authenticated
        /// </summary>
        protected virtual bool IsUserAuthenticated { get { return User.Identity.IsAuthenticated; } }
    }
}
