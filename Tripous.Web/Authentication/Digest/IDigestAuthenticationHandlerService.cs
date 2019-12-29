using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tripous.Web.Authentication.Digest
{

    /// <summary>
    /// The implementation of the Digest Authentication can NOT work without this service.
    /// The user has to implement the service and register it with the DI, probably as a singleton service.
    /// <para>The service 1. persists Nonces, 2. loads the user's password (perhaps from a database) and 3. logs-out the user.</para>
    /// <para>Nonces could be stored in a memory cache, when a single instance of the application is used.</para>
    /// <para>When multiple instances of the application is used, i.e. a web farm, then consider using a distributed cache or a database in storing Nonces.</para> 
    /// </summary>
    public interface IDigestAuthenticationHandlerService
    {
        /// <summary>
        /// Saves a Nonce. If the Nonce does not exist, it insert a new one. Else it updates the existing Nonce.
        /// <para>The <see cref="DigestNonce.Value"/> should be used as the Primary Key.</para>
        /// </summary>
        public void Save(DigestNonce Nonce);
        /// <summary>
        /// Loads and returns a <see cref="DigestNonce"/> instance based on a specified Nonce value.
        /// If the Nonce does not exist, then returns null.
        /// </summary>
        public DigestNonce Load(string NonceValue);
        /// <summary>
        /// Removes a <see cref="DigestNonce"/> instance based on a specified Nonce value.
        /// </summary>
        public void Remove(string NonceValue);

        /// <summary>
        /// Loads and returns the password of a user based on a specified user name
        /// </summary>
        public string LoadPassword(string Username);
        /// <summary>
        /// Logs-out a user by actually removing the user from the persistence medium (memory cache, database, etc.)
        /// </summary>
        public void Logout(string UserName);
    }
}
