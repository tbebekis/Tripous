/*--------------------------------------------------------------------------------------        
                           Copyright © 2018 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tripous
{

    /// <summary>
    /// Helper json static class
    /// </summary>
    static public class Json
    {
     
        

        static JsonSerializerSettings CreateDefaultSettings()
        {
            JsonSerializerSettings Result = new JsonSerializerSettings();

            Result = new Newtonsoft.Json.JsonSerializerSettings();
            Result.Formatting = Newtonsoft.Json.Formatting.Indented;
            Result.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            return Result;
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        static Json()
        {
        }

        /* public */
        /// <summary>
        /// Returns a specified json text as formatted for readability.
        /// </summary>
        static public string Format(string JsonText)
        {
            if (string.IsNullOrWhiteSpace(JsonText))
                return string.Empty;

            dynamic parsedJson = JsonConvert.DeserializeObject(JsonText);
            return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
        }

        /// <summary>
        /// Converts Instance to a json string using the NewtonSoft json serializer.
        /// <para>If no settings specified then it uses the default JsonSerializerSettings</para> 
        /// </summary>
        static public string ToJson(object Instance, JsonSerializerSettings Settings = null)
        {
            string Result = string.Empty;

            if (Instance != null)
            {
                Settings = Settings == null ? DefaultSettings : Settings;
                return JsonConvert.SerializeObject(Instance, Settings);
            }

            return Result;
        }
        /// <summary>
        /// Converts a specified Instance to json text.
        /// <para> ExcludeProperties, if not null, may contain property names to be ignored</para>
        /// </summary>
        static public string ToJson(object Instance, string[] ExcludeProperties)
        {
            string Result = string.Empty;
            if (Instance != null)
            {
                JsonSerializerSettings Settings = CreateDefaultSettings();

                if (ExcludeProperties != null && ExcludeProperties.Length > 0)
                {
                    Settings.ContractResolver = new JsonNetContractResolver(ExcludeProperties);
                }

                Result = ToJson(Instance, Settings);
            }

            return Result;
        }

        /// <summary>
        /// Converts an object to JObject
        /// </summary>
        static public JObject AsJObject(object Instance)
        {
            string JsonText = ToJson(Instance);
            return JObject.Parse(JsonText);
        }
        /// <summary>
        /// Converts json text to a dynamic object
        /// </summary>
        static public dynamic AsDynamic(string JsonText)
        {
            return !string.IsNullOrWhiteSpace(JsonText) ? JsonConvert.DeserializeObject(JsonText) as dynamic : null;
        }

        /// <summary>
        /// Deserializes (creates) an object of a specified type by deserializing a specified json text.
        /// <para>If no settings specified then it uses the default JsonSerializerSettings</para> 
        /// </summary>
        static public object FromJson(Type ClassType, string JsonText, JsonSerializerSettings Settings = null)
        {
            if (!string.IsNullOrWhiteSpace(JsonText))
            {
                Settings = Settings == null ? DefaultSettings : Settings;
                return JsonConvert.DeserializeObject(JsonText, ClassType, Settings);
            }

            return null;
        }
        /// <summary>
        /// Loads an object's properties from a specified json text.
        /// <para>If no settings specified then it uses the default JsonSerializerSettings</para> 
        /// </summary>
        static public void FromJson(object Instance, string JsonText, JsonSerializerSettings Settings = null)
        {
            if (!string.IsNullOrWhiteSpace(JsonText))
            {
                Settings = Settings == null ? DefaultSettings : Settings;
                JsonConvert.PopulateObject(JsonText, Instance, Settings);
            }
        }
        /// <summary>
        /// Converts json text to a typed object
        /// </summary>
        static public T FromJson<T>(string JsonText, JsonSerializerSettings Settings = null)
        {

            if (!string.IsNullOrWhiteSpace(JsonText))
            {
                Settings = Settings == null ? DefaultSettings : Settings;
                return JsonConvert.DeserializeObject<T>(JsonText, Settings);
            }

            return default(T);
        }

        /// <summary>
        /// Converts Instance to a json string using the NewtonSoft json serializer and then to stream.
        /// <para>If no settings specified then it uses the default JsonSerializerSettings</para> 
        /// <para>NOTE: UTF8 encoding is used.</para>
        /// </summary>
        static public MemoryStream ToJsonStream(object Instance, JsonSerializerSettings Settings = null)
        {
            MemoryStream MS = new MemoryStream();
            ToJsonStream(Instance, MS, Settings);
            return MS;
        }
        /// <summary>
        /// Converts Instance to a json string using the NewtonSoft json serializer and then to stream.
        /// <para>If no settings specified then it uses the default JsonSerializerSettings</para> 
        /// <para>NOTE: UTF8 encoding is used.</para>
        /// </summary>
        static public void ToJsonStream(object Instance, Stream Stream, JsonSerializerSettings Settings = null)
        {
            string JsonText = ToJson(Instance, Settings);
            JsonTextToStream(JsonText, Stream);
        }

        /// <summary>
        /// Reads the json text from a stream and then deserializes (creates) an object of a specified type.
        /// <para>If no settings specified then it uses the default JsonSerializerSettings</para> 
        /// <para>NOTE: UTF8 encoding is used.</para>
        /// </summary>
        static public object FromJsonStream(Type ClassType, Stream Stream, JsonSerializerSettings Settings = null)
        {
            string JsonText = StreamToJsonText(Stream);
            return FromJson(ClassType, JsonText, Settings);
        }
        /// <summary>
        /// Loads an object's properties from a specified stream, after reading the json text from the stream.
        /// <para>If no settings specified then it uses the default JsonSerializerSettings</para> 
        /// <para>NOTE: UTF8 encoding is used.</para>
        /// </summary>
        static public void FromJsonStream(object Instance, Stream Stream, JsonSerializerSettings Settings = null)
        {
            string JsonText = StreamToJsonText(Stream);
            FromJson(Instance, JsonText, Settings);
        }

        /// <summary>
        /// Converts a specified json text to a stream.
        /// <para>NOTE: UTF8 encoding is used.</para>
        /// </summary>
        static public MemoryStream JsonTextToStream(string JsonText)
        {
            MemoryStream MS = new MemoryStream();
            JsonTextToStream(JsonText, MS);
            return MS;
        }
        /// <summary>
        /// Converts a specified json text to a stream.
        /// <para>NOTE: UTF8 encoding is used.</para>
        /// </summary>
        static public void JsonTextToStream(string JsonText, Stream Stream)
        {
            byte[] Buffer = Encoding.UTF8.GetBytes(JsonText);
            Stream.Write(Buffer, 0, Buffer.Length);
        }

        /// <summary>
        /// Reads a stream as json text.
        /// <para>NOTE: UTF8 encoding is used.</para>
        /// </summary>
        static public string StreamToJsonText(Stream Stream)
        {
            string JsonText = string.Empty;
            if (Stream != null && Stream.Length > 0)
            {
                using (StreamReader reader = new StreamReader(Stream, Encoding.UTF8))
                {
                    JsonText = reader.ReadToEnd();
                }
            }

            return JsonText;
        }

        /// <summary>
        /// Returns the text of the input stream of a request (HttpContext.Request.Body) as a Dictionary. To be used when POST-ing json data.
        /// </summary>
        static public Dictionary<string, dynamic> GetRequestDic(Stream RequestBodyStream)
        {
            if (RequestBodyStream != null && RequestBodyStream.CanSeek)
            {
                string Text = StreamToJsonText(RequestBodyStream);
                if (!string.IsNullOrWhiteSpace(Text))
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(Text);
                }
            }

            return new Dictionary<string, dynamic>();
        }


        /// <summary>
        /// Saves an instance as json text in a specified file.
        /// </summary>
        static public void SaveToFile(object Instance, string FilePath, string Encoding = "utf-8")
        {
            string Folder = Path.GetDirectoryName(FilePath);
            if (!string.IsNullOrWhiteSpace(Folder))
                Directory.CreateDirectory(Folder);
            string JsonText = ToJson(Instance);
            File.WriteAllText(FilePath, JsonText, System.Text.Encoding.GetEncoding(Encoding));
        }

        /// <summary>
        /// Loads the properties of an instance by reading the json text of a specified file.
        /// </summary>
        static public void LoadFromFile(object Instance, string FilePath, string Encoding = "utf-8")
        {
            if (File.Exists(FilePath))
            {
                string JsonText = File.ReadAllText(FilePath, System.Text.Encoding.GetEncoding(Encoding));
                FromJson(Instance, JsonText);
            }
        }
        /// <summary>
        ///  Creates and returns an object of ClassType using the json text of a specified file
        /// </summary>
        static public object LoadFromFile(Type ClassType, string FilePath, string Encoding = "utf-8")
        {
            if (File.Exists(FilePath))
            {
                string JsonText = File.ReadAllText(FilePath, System.Text.Encoding.GetEncoding(Encoding));
                return FromJson(ClassType, JsonText);
            }

            return null;
        }

        /// <summary>
        /// Returns the value of a <see cref="JProperty"/>.
        /// </summary>
        static public T AsValue<T>(JProperty Prop, T Default)
        {
            T Result = Default;
            if ((Prop != null))
            {
                try
                {
                    Result = Prop.Value.Value<T>();
                }
                catch
                {
                }
            }

            return Result;
        }

        /// <summary>
        /// Default settings
        /// </summary>
        static public JsonSerializerSettings DefaultSettings { get; set; }  = CreateDefaultSettings();
    }
}
