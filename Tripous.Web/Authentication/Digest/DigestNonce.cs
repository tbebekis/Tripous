using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tripous.Web.Authentication.Digest
{

    /// <summary>
    /// Represents the nonce. SEE: https://tools.ietf.org/html/rfc7616#section-3.3
    /// <para>Used in caching authenticated users along with the nonce.</para>
    /// </summary>
    public class DigestNonce
    {
        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public DigestNonce()
        {
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public DigestNonce(DigestNonce Source)
        {
            Assign(Source);
        }

        /* public */
        /// <summary>
        /// Assigns this instance from the properties of a specified source instance.
        /// </summary>
        public virtual void Assign(DigestNonce Source)
        {
            Value = Source.Value;
            Username = Source.Username;
            Counter = Source.Counter;
            ExpiresUtc = Source.ExpiresUtc;
        }

        /* properties */
        /// <summary>
        /// The nonce value. SEE: https://tools.ietf.org/html/rfc7616#section-3.3
        /// <para>NOTE: This property acts as the Primary Key.</para>
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// The user name
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// The nonce counter, nc in Specs. SEE: https://tools.ietf.org/html/rfc7616#section-3.4
        /// </summary>
        public int Counter { get; set; }    
        /// <summary>
        /// The nonce expiration date-time
        /// </summary>
        public DateTime ExpiresUtc { get; set; }
    }
}

 
