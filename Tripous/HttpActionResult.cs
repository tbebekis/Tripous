using System;
using System.Collections.Generic;
using System.Text;

namespace Tripous
{
    /// <summary>
    /// To be used by controller action methods returning json data. 
    /// </summary>
    public class HttpActionResult
    {

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public HttpActionResult()
        {
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public HttpActionResult(object Packet, bool IsSuccess = true)
        {
            SerializePacket(Packet);
            this.IsSuccess = IsSuccess;
        }

        /* public */
        /// <summary>
        /// Serializes a specified instance and assigns the Packet string property
        /// </summary>
        public void SerializePacket(object Packet)
        {
            if (Packet != null)
                this.Packet = Json.ToJson(Packet);
        }
        /// <summary>
        /// Deserializes Packet string property to an instance of a specified type
        /// </summary>
        public T DeserializePacket<T>()
        {
            return Json.FromJson<T>(this.Packet);
        }


        /* properties */
        /// <summary>
        /// A text or json text. This is the actual information returned to the caller.
        /// </summary>
        public string Packet { get; set; }
        /// <summary>
        /// Contains error information or is null or empty
        /// </summary>
        public string ErrorText { get; set; }
        /// <summary>
        /// True when the call succeeds business-logic-wise.
        /// </summary>
        public bool IsSuccess { get; set; } = false;
    }
}
