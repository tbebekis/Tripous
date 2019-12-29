using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Diagnostics;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.Features;

using Newtonsoft;
using Newtonsoft.Json;


namespace Tripous.Web
{
    /// <summary>
    /// Error information container
    /// </summary>
    public class WebErrorInfo
    {
        /* private */
        int GetHttpStatusCode(Exception Ex, HttpContext Context)
        {
            if (Ex is ExceptionEx && (Ex as ExceptionEx).StatusCode != System.Net.HttpStatusCode.OK)
            {
                HttpStatus = Enum.GetName(typeof(System.Net.HttpStatusCode), (Ex as ExceptionEx).StatusCode);
                return (int)(Ex as ExceptionEx).StatusCode;
            }

            if (Context != null && Context.Response != null)
            {
                HttpStatus = Enum.GetName(typeof(System.Net.HttpStatusCode), Context.Response.StatusCode);
                return Context.Response.StatusCode;
            }

            return 0;

        }
        string GetRequestUrl(Exception Ex, HttpContext Context)
        {
            if (Context != null)
            {
                IExceptionHandlerPathFeature Feature = Context.Features.Get<IExceptionHandlerPathFeature>();

                if (Feature != null)
                    return Feature.Path;
            }

            return string.Empty;
        }
        string GetRequestId(Exception Ex, HttpContext Context)
        {
            if (Activity.Current != null && !string.IsNullOrWhiteSpace(Activity.Current.Id))
                return Activity.Current.Id;

            if (Context != null)
                return Context.TraceIdentifier;

            return string.Empty;
        }
        void Prepare(Exception Ex, HttpContext Context)
        {
            if (Ex != null)
            {
                Message = Ex.Message;
                AppErrorCode = Ex is ExceptionEx ? (Ex as ExceptionEx).ErrorCode : 0;
                Details = ExceptionEx.GetExceptionText(Ex);
            }

            HttpStatusCode = GetHttpStatusCode(Ex, Context);
            RequestUrl = GetRequestUrl(Ex, Context);
            RequestId = GetRequestId(Ex, Context);
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public WebErrorInfo()
        {
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public WebErrorInfo(HttpContext Context)
        {
            IExceptionHandlerPathFeature Feature = Context.Features.Get<IExceptionHandlerPathFeature>();
            this.Exception = Feature.Error;

            Prepare(Feature.Error, Context);
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public WebErrorInfo(Exception Ex, HttpContext Context)
        {
            this.Exception = Ex;

            Prepare(Ex, Context);
        }

        /* public */
        /// <summary>
        /// Override
        /// </summary>
        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();
            SB.AppendLine(string.Format("HttpStatusCode: {0}", this.HttpStatusCode));
            SB.AppendLine(string.Format("HttpStatus: {0}", this.HttpStatus));
            SB.AppendLine(string.Format("AppErrorCode: {0}", this.AppErrorCode));
            SB.AppendLine(string.Format("RequestId: {0}", this.RequestId));
            SB.AppendLine(string.Format("RequestUrl: {0}", this.RequestUrl));
            SB.AppendLine(string.Format("Message: {0}", this.Message));
            SB.AppendLine(string.Format("Details: {0}", this.Details));
            return SB.ToString();
        }
        /// <summary>
        /// Returns the properties of this instance as a dictionary.
        /// </summary>
        public IDictionary<string, object> ToDictionary()
        {
            Dictionary<string, object> Dic = new Dictionary<string, object>();
            Dic["HttpStatusCode"] = this.HttpStatusCode;
            Dic["HttpStatus"] = this.HttpStatus;
            Dic["AppErrorCode"] = this.AppErrorCode;
            Dic["RequestId"] = this.RequestId;
            Dic["RequestUrl"] = this.RequestUrl;
            Dic["Message"] = this.Message;
            Dic["Details"] = this.Details;

            return Dic;
        }

        /* properties */
        /// <summary>
        /// Exception
        /// </summary>
        [JsonIgnore]
        public Exception Exception { get; set; }
        /// <summary>
        /// HttpStatusCode
        /// </summary>
        public int HttpStatusCode { get; set; }
        /// <summary>
        /// HttpStatus
        /// </summary>
        public string HttpStatus { get; set; }
        /// <summary>
        /// AppErrorCode
        /// </summary>
        public int AppErrorCode { get; set; }
        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; } = "Unknown error.";
        /// <summary>
        /// RequestId
        /// </summary>
        public string RequestId { get; set; }
        /// <summary>
        /// RequestUrl
        /// </summary>
        public string RequestUrl { get; set; }
        /// <summary>
        /// Details
        /// </summary>
        public string Details { get; set; }
    }
}
