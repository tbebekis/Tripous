/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/
using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Text;

using Newtonsoft.Json;
 


namespace Tripous.Data
{


    /// <summary>
    /// Simulates an .ini file using a table in a database
    /// </summary>
    public class DbIni
    {
        /* fields */
        private SqlStore Store = null;

        private string tableName = SysTables.Ini;
        private string entryField = "EntryKey";
        private string valueField = "EntryValue";
        private string blobField = "EntryData";

        /// <summary>
        /// Ensures that the ini table exists in database.
        /// </summary>
        private void EnsureTableExists()
        {
            if (!Store.TableExists(tableName))
            {
                string SqlText =
                                "create table {0} (         " +
                                " {1}    @VARCHAR(512)       " +
                                ",{2}    @VARCHAR(2048)      " +
                                ",{3}    @BLOB              " +
                                ")                          " +
                                "";

                SqlText = string.Format(SqlText, tableName, entryField, valueField, blobField);

                Store.CreateTable(SqlText);
            }
        }

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public DbIni(SqlConnectionInfo ConnectionInfo, string TableName, string EntryField, string ValueField, string BlobField)
        {
            this.Store = new SqlStore(ConnectionInfo);
            tableName = TableName;
            entryField = EntryField;
            valueField = ValueField;
            blobField = BlobField;

            EnsureTableExists();
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public DbIni(SqlConnectionInfo ConnectionInfo)
            : this(ConnectionInfo, SysTables.Ini, "EntryKey", "EntryValue", "EntryData")
        {
        }

        /* public */
        /// <summary>
        /// Returns true if Entry exists in table
        /// </summary>
        public bool Exists(string Entry)
        {
            string SqlText = string.Format("select {0} from {1} where {0} = '{2}' ", entryField, tableName, Entry);
            DataRow Row = Store.SelectResults(SqlText);
            return (Row != null);
        }
        /// <summary>
        /// Deletes the Entry from table
        /// </summary>
        public void Delete(string Entry)
        {
            string SqlText = string.Format("delete from {0} where {1} = '{2}' ", tableName, entryField, Entry);
            Store.ExecSql(SqlText);
        }

        /// <summary>
        /// Writes the Value to the Entry. If the Entry does not exist, it created.
        /// </summary>
        public void WriteString(string Entry, string Value)
        {
            string SqlText;

            if (Exists(Entry))
                SqlText = string.Format("update {0} set {1} = '{2}'  where {3} = '{4}'  ", tableName, valueField, Value, entryField, Entry);
            else
                SqlText = string.Format("insert into {0} ({1}, {2}) values ('{3}', '{4}')", tableName, entryField, valueField, Entry, Value);

            Store.ExecSql(SqlText);
        }
        /// <summary>
        /// Returns the Value of the Entry, if exists, else Default
        /// </summary>
        public string ReadString(string Entry, string Default)
        {
            string SqlText = string.Format("select {0} from {1} where {2} = '{3}' ", valueField, tableName, entryField, Entry);
            DataRow Row = Store.SelectResults(SqlText);
            if ((Row != null) && (!Row.IsNull(valueField)))
                return Row[valueField].ToString();

            return Default;
        }

        /// <summary>
        /// Writes the Value to the Entry. If the Entry does not exist, it created.
        /// </summary>
        public void WriteInteger(string Entry, int Value)
        {
            WriteString(Entry, Value.ToString());
        }
        /// <summary>
        /// Returns the Value of the Entry, if exists, else Default
        /// </summary>
        public int ReadInteger(string Entry, int Default)
        {
            return Sys.AsInteger(ReadString(Entry, Default.ToString()), Default);
        }

        /// <summary>
        /// Writes the Value to the Entry. If the Entry does not exist, it created.
        /// </summary>
        public void WriteFloat(string Entry, double Value)
        {
            WriteString(Entry, Sys.DoubleToStr(Value));
        }
        /// <summary>
        /// Returns the Value of the Entry, if exists, else Default
        /// </summary>
        public double ReadFloat(string Entry, double Default)
        {
            return Sys.AsDouble(ReadString(Entry, Default.ToString()), Default);
        }

        /// <summary>
        /// Writes the Value to the Entry. If the Entry does not exist, it created.
        /// </summary>
        public void WriteBool(string Entry, bool Value)
        {
            WriteString(Entry, Value.ToString());
        }
        /// <summary>
        /// Returns the Value of the Entry, if exists, else Default
        /// </summary>
        public bool ReadBool(string Entry, bool Default)
        {
            return Sys.AsBoolean(ReadString(Entry, Default.ToString()), Default);
        }

        /// <summary>
        /// Writes the Value to the Entry. If the Entry does not exist, it created.
        /// </summary>
        public void WriteDateTime(string Entry, DateTime Value)
        {
            WriteString(Entry, Sys.DateTimeToStr(Value, false));
        }
        /// <summary>
        /// Returns the Value of the Entry, if exists, else Default
        /// </summary>
        public DateTime ReadDateTime(string Entry, DateTime Default)
        {
            return Sys.AsDateTime(ReadString(Entry, Default.ToString()), Default);
        }

        /// <summary>
        /// Writes the Value and Stream to the Entry. If the Entry does not exist, it created.
        /// </summary>
        public void WriteBlob(string Entry, Stream Stream, string Value)
        {
            DataTable Table = new DataTable();
            Table.Columns.Add(blobField, typeof(byte[]));

            byte[] Bytes = new byte[Stream.Length];
            Stream.Position = 0;
            Stream.Read(Bytes, 0, Convert.ToInt32(Stream.Length));

            Table.Rows.Add(Bytes);

            string SqlText;


            if (Exists(Entry))
            {
                SqlText = string.Format("update {0} set {1} = '{2}', {3} = :{3} where {4} = '{5}' ",
                    tableName, valueField, Value, blobField, entryField, Entry);
            }
            else
            {
                SqlText = string.Format("insert into {0} ({1}, {2}, {3}) values ('{4}', '{5}', :{3})",
                    tableName, entryField, valueField, blobField, Entry, Value);
            }


            Store.ExecSql(SqlText, Table.Rows[0]);
        }
        /// <summary>
        /// Writes the Stream to the Entry. If the Entry does not exist, it created.
        /// </summary>
        public void WriteBlob(string Entry, Stream Stream)
        {
            WriteBlob(Entry, Stream, "");
        }
        /// <summary>
        /// Reads the Entry to the Stream and Value. Returns true if the Entry exists.
        /// </summary>
        public bool ReadBlob(string Entry, Stream Stream, ref string Value)
        {
            bool Result = false;

            string SqlText = string.Format("select * from {0} where {1} = '{2}' ", tableName, entryField, Entry);
            DataRow Row = Store.SelectResults(SqlText);
            if (Row != null)
            {
                Result = true;

                if (!Row.IsNull(blobField))
                {
                    byte[] Bytes = (byte[])Row[blobField];
                    if (Bytes.Length > 0)
                    {
                        Stream.Write(Bytes, 0, Bytes.Length);
                        Stream.Position = 0;
                    }
                }

                if (!Row.IsNull(entryField))
                    Value = Row[entryField].ToString();

            }

            return Result;

        }
        /// <summary>
        /// Reads the Entry to the Stream. Returns true if the Entry exists.
        /// </summary>
        public bool ReadBlob(string Entry, Stream Stream)
        {
            string Value = "";
            return ReadBlob(Entry, Stream, ref Value);
        }

        /// <summary>
        /// Loads Instance from a DbIni blob
        /// </summary>
        public bool ReadInstance(string Entry, object Instance)
        {
            string JsonText = string.Empty;

            // load from db ini
            using (MemoryStream MS = new MemoryStream())
            {
                ReadBlob(Entry, MS);
                MS.Position = 0;
                
                using (StreamReader reader = new StreamReader(MS, Encoding.UTF8))
                {
                    JsonText = reader.ReadToEnd();
                }
            }
 
            if (!string.IsNullOrWhiteSpace(JsonText))
            {
                JsonConvert.PopulateObject(JsonText, Instance);
                return true;
            }

            return false;
        }
        /// <summary>
        /// Saves Instance to a DbIni blob
        /// </summary>
        public void WriteInstance(string Entry, object Instance)
        {
            // save to db ini
            string JsonText = JsonConvert.SerializeObject(Instance);
            byte[] Buffer = Encoding.UTF8.GetBytes(JsonText);
 
            using (MemoryStream MS = new MemoryStream())
            {
                MS.Write(Buffer, 0, Buffer.Length);
                MS.Position = 0;
                WriteBlob(Entry, MS);
            }
        }

    }
}
