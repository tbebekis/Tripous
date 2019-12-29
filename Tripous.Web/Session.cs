﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Tripous.Web
{
    /// <summary>
    /// Provides access to session variables (entries)
    /// </summary>
    static public class Session
    {
        /* private */
        /// <summary>
        /// Returns a value stored in session, found under a specified key or a default value if not found.
        /// </summary>
        static T Get<T>(this ISession Instance, string Key)
        {
            Key = Key.ToLowerInvariant();
            string JsonText = Instance.GetString(Key);
            if (JsonText == null)
                return default(T);

            return JsonConvert.DeserializeObject<T>(JsonText);
        }
        /// <summary>
        /// Returns a value stored in session, found under a specified key or a default value if not found.
        /// </summary>
        static T Get<T>(this ISession Instance, string Key, T Default)
        {
            Key = Key.ToLowerInvariant();
            string JsonText = Instance.GetString(Key);
            if (JsonText == null)
                return Default;

            return JsonConvert.DeserializeObject<T>(JsonText);
        }
        /// <summary>
        /// Stores a value in session under a specified key.
        /// </summary>
        static void Set<T>(this ISession Instance, string Key, T Value)
        {
            Key = Key.ToLowerInvariant();
            string JsonText = JsonConvert.SerializeObject(Value);
            Instance.SetString(Key, JsonText);
        }

        /* public */
        /// <summary>
        /// Returns a value stored in session, found under a specified key or a default value if not found.
        /// </summary>
        static public T Get<T>(string Key)
        {
            return WSys.HttpContext.Session.Get<T>(Key);
        }
        /// <summary>
        /// Returns a value stored in session, found under a specified key or a default value if not found.
        /// </summary>
        static public T Get<T>(string Key, T Default)
        {
            return WSys.HttpContext.Session.Get(Key, Default);
        }
        /// <summary>
        /// Stores a value in session under a specified key.
        /// </summary>
        static public void Set<T>(string Key, T Value)
        {
            WSys.HttpContext.Session.Set(Key, Value);
        }

        /// <summary>
        /// Returns a string stored in session, found under a specified key or null if not found.
        /// </summary>
        static public string GetString(string Key)
        {
            return Get<string>(Key, null);
        }
        /// <summary>
        /// Stores a string value in session under a specified key.
        /// </summary>
        static public void SetString(string Key, string Value)
        {
            Set(Key, Value);
        }

        /// <summary>
        /// Clears all session variables
        /// </summary>
        static public void Clear()
        {
            WSys.HttpContext.Session.Clear();
        }
        /// <summary>
        /// Removes a session variable under a specified key.
        /// </summary>
        static public void Remove(string Key)
        {
            Key = Key.ToLowerInvariant();
            WSys.HttpContext.Session.Remove(Key);
        }
        /// <summary>
        /// Returns true if a variable exists in session under a specified key.
        /// </summary>
        static public bool ContainsKey(string Key)
        {
            Key = Key.ToLowerInvariant();
            byte[] Buffer = null;
            return WSys.HttpContext.Session.TryGetValue(Key, out Buffer);
        }

        /* properties */
        /// <summary>
        /// Provides acces to request variables.
        /// <para>This dictionary is used to store data while processing a single request. The dictionary's contents are discarded after a request is processed.</para>
        /// </summary>
        static public IDictionary<object, object> Request { get { return WSys.HttpContext.Items; } }

        /// <summary>
        /// Gets or sets the language code, e.g en-US, el-GR, etc.
        /// <para>Sets the session current culture too.</para>
        /// </summary>
        static public string LanguageCode
        {
            get
            {
                CultureInfo CI = Culture;
                return CI != null ? CI.Name : CultureInfo.CurrentCulture.Name;
            }
            set
            {
                CultureInfo CI = new CultureInfo(value);
                Culture = CI;
            }
        }
        /// <summary>
        /// Gets or sets the session culture.
        /// </summary>
        static public CultureInfo Culture
        {
            get
            {
                CultureInfo Result = Get<CultureInfo>("Culture", null);
                return Result != null ? Result : CultureInfo.CurrentCulture;
            }
            set
            {
                CultureInfo.CurrentCulture = value;
                CultureInfo.CurrentUICulture = value;
                Set<CultureInfo>("Culture", value);
            }
        }

    }
}
