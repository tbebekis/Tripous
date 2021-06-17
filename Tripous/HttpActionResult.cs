﻿using System;
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
        /*
                /// <summary>
                /// Constructor
                /// </summary>
                public HttpActionResult(object Packet, bool IsSuccess = true)
                {
                    SerializePacket(Packet);
                    this.IsSuccess = IsSuccess;
                } 
         */

        /// <summary>
        /// Creates and returns a result.
        /// <para>Use this when the caller waits the Packet to be serialized as JSON text.</para>
        /// </summary>
        static public HttpActionResult SetPacket(object Packet, bool IsSuccess = true)
        {
            HttpActionResult Result = new HttpActionResult();
            Result.SerializePacket(Packet);
            Result.IsSuccess = IsSuccess;
            return Result;
        }
        /// <summary>
        /// Creates and returns a result.
        /// Use this when the caller waits for the Entity to be part of the whole JSON returned.
        /// </summary>
        static public HttpActionResult SetEntity(object Entity, bool IsSuccess = true)
        {
            HttpActionResult Result = new HttpActionResult();
            Result.Entity = Entity;
            Result.IsSuccess = IsSuccess;
            return Result;
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
        /// An object that is serialized along with this result as a whole.
        /// </summary>
        public object Entity { get; set; }
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
