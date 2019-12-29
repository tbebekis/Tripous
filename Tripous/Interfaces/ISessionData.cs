using System;
using System.Collections.Generic;
using System.Text;

namespace Tripous
{

    /// <summary>
    /// A store for saving and retreiving data per session.
    /// <para>Each type of application (desktop, web, etc) has to provide a proper session data implementation.</para>
    /// <para>The concrete instance sould be registered in the Sys global object.</para>
    /// </summary>
    public interface ISessionData
    {
        /* methods */
        /// <summary>
        /// Removes all entries
        /// </summary>
        void Clear();
        /// <summary>
        /// Removes a specified entry, if any.
        /// </summary>
        void Remove(string Key);
        /// <summary>
        /// Returns true if a specified key exists in the entries.
        /// </summary>
        bool Contains(string Key);

        /// <summary>
        /// Returns a value under a specified key, if any, else a default value.
        /// </summary>
        string AsString(string Key, string Default = "");
        /// <summary>
        /// Returns a value under a specified key, if any, else a default value.
        /// </summary>
        int AsInteger(string Key, int Default = Int32.MinValue);
        /// <summary>
        /// Returns a value under a specified key, if any, else a default value.
        /// </summary>
        decimal AsFloat(string Key, decimal Default = Decimal.MinValue);
        /// <summary>
        /// Returns a value under a specified key, if any, else a default value.
        /// </summary>
        bool AsBoolean(string Key, bool Default = false);
        /// <summary>
        /// Returns a value under a specified key, if any, else a default value.
        /// </summary>
        DateTime AsDateTime(string Key);
        /// <summary>
        /// Returns a value under a specified key, if any, else a default value.
        /// </summary>
        object AsObject(string Key, object Default = null);

        /// <summary>
        /// Sets a new entry or updates an existing entry, under a specified key.
        /// </summary>
        void SetAsString(string Key, string Value);
        /// <summary>
        /// Sets a new entry or updates an existing entry, under a specified key.
        /// </summary>
        void SetAsInteger(string Key, int Value);
        /// <summary>
        /// Sets a new entry or updates an existing entry, under a specified key.
        /// </summary>
        void SetAsFloat(string Key, decimal Value);
        /// <summary>
        /// Sets a new entry or updates an existing entry, under a specified key.
        /// </summary>
        void SetAsBoolean(string Key, bool Value);
        /// <summary>
        /// Sets a new entry or updates an existing entry, under a specified key.
        /// </summary>
        void SetAsDateTime(string Key, DateTime Value);
        /// <summary>
        /// Sets a new entry or updates an existing entry, under a specified key.
        /// </summary>
        void SetAsObject(string Key, object Value);

        /* properties */
        /// <summary>
        /// A unique identifier of the session
        /// </summary>
        string Id { get; }
        /// <summary>
        /// True when the session is valid
        /// </summary>
        bool IsValid { get; }
        /// <summary>
        /// Returns an enumerable sequence of all keys.
        /// </summary>
        IEnumerable<string> Keys { get; }

        /// <summary>
        /// The User Id, a value that has no business meaning.
        /// </summary>
        string UserId { get; }
        /// <summary>
        /// The User name, used by system log on.
        /// </summary>
        string UserName { get; }
    }
}
