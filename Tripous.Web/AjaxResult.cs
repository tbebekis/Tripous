using System;
using System.Collections.Generic;
using System.Text;

namespace Tripous.Web
{
    /// <summary>
    /// The action result used with ajax calls
    /// </summary>
    public class AjaxResult
    {

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public AjaxResult()
        {
        }

        /* public */
        /// <summary>
        /// Serializes a specified instance and assigns the Packet string property
        /// </summary>
        public void SerializePacket(object Packet)
        {
            this.Packet = Tripous.Json.ToJson(Packet);
        }
        /// <summary>
        /// Deserializes Packet string property to an instance of a specified type
        /// </summary>
        public T DeserializePacket<T>()
        {
            return Tripous.Json.FromJson<T>(this.Packet);
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
        /// True when the call succeeds.
        /// </summary>
        public bool Result { get; set; } = false;
    }
}
