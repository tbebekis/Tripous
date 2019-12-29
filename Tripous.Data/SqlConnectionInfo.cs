using System;

namespace Tripous.Data
{

    /// <summary>
    /// Connection string settings
    /// </summary>
    public class SqlConnectionInfo
    {

        SqlProvider fSqlProvider;

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public SqlConnectionInfo()
        {
        }

        /* public */
        /// <summary>
        /// Returns the <see cref="SqlProvider"/> of this connection string. If the provider is not registered with <see cref="SqlProviders"/> an exception is thrown.
        /// </summary>
        public SqlProvider GetSqlProvider()
        {
            if (fSqlProvider == null)
            {
                fSqlProvider = SqlProviders.GetSqlProvider(Provider);
            }

            return fSqlProvider;
        }
        /// <summary>
        /// Returns a string representation of this instance.
        /// </summary>
        public override string ToString()
        {
            return $"{Provider}:{Name}";
        }



        /* properties */
        /// <summary>
        /// The name of this connection
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The name of the provider, e.g. MsSql, Oracle, SQLite, etc.
        /// </summary>
        public string Provider { get; set; }
        /// <summary>
        /// The connection string
        /// </summary>
        public string ConnectionString { get; set; }
        /// <summary>
        /// Where to create table generators/sequences automatically 
        /// </summary>
        public bool AutoCreateGenerators { get; set; }

        /// <summary>
        /// The time in seconds to wait for an SELECT/INSERT/UPDATE/DELETE/CREATE TABLE ect. command to execute.
        /// </summary>
        public int CommandTimeoutSeconds { get; set; }
    }
}
