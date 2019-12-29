/*--------------------------------------------------------------------------------------        
                           Copyright © 2018 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Tripous
{

    // TODO: Prepei na ginei ena context kai gia desktop kai gia web

    /// <summary>
    /// A base class for coding Context-like classess with case-insensitive keys
    /// </summary>
    public class ContextBase
    {

        /// <summary>
        /// An internal dictionary
        /// </summary>
        protected Dictionary<string, object> Dic = new Dictionary<string, object>();
        
        /// <summary>
        /// Returns a value from the internal dictionary found under a key, if any, else null.
        /// </summary>
        protected virtual object GetValue(string Key)
        {
            foreach (var Entry in Dic)
            {
                if (string.Compare(Key, Entry.Key, StringComparison.InvariantCultureIgnoreCase) == 0)
                    return Entry.Value;
            }
            return null;
        }
        /// <summary>
        /// Puts a value in the internal dictionary under a key.
        /// </summary>
        protected virtual void SetValue(string Key, object Value)
        {
            foreach (var Entry in Dic)
            {
                if (string.Compare(Key, Entry.Key, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    Dic[Entry.Key] = Value;
                    return;
                }
            }

            Dic[Key] = Value;
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public ContextBase()
        {
        }

        /* public */
        /// <summary>
        /// Returns a context variable in a safe manner
        /// <para>NOTE: Keys are NOT case-sensitive.</para>
        /// </summary>
        public T ValueOf<T>(string Key, T Default)
        {
            try
            {
                object Value = GetValue(Key);

                return (T)(Sys.IsNull(Value) ? Default : Value);
            }
            catch
            {
                return Default;
            }
        }
        /// <summary>
        /// True if Key has a value
        /// <para>NOTE: Keys are NOT case-sensitive.</para>
        /// </summary>
        public bool Contains(string Key)
        {
            return GetValue(Key) != null;
        }
        /// <summary>
        /// Removes an entry by Key
        /// <para>NOTE: Keys are NOT case-sensitive.</para>
        /// </summary>
        public void Remove(string Key)
        {
            foreach (var Entry in Dic)
            {
                if (string.Compare(Key, Entry.Key, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    Dic.Remove(Entry.Key);
                    return;
                }
            }
        }

        /* properties */
        /// <summary>
        /// Indexer. Returns null if Key does not exist.
        /// <para>NOTE: Keys are NOT case-sensitive.</para>
        /// </summary>
        public object this[string Key]
        {
            get { return GetValue(Key); }
            set { SetValue(Key, value); }

        }
    }
}
