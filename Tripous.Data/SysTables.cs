/*--------------------------------------------------------------------------------------        
                           Copyright © 2018 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tripous.Data
{

    /// <summary>
    /// Helper config class with the system table names
    /// </summary>
    static public class SysTables
    {
        static Dictionary<string, string> names = new Dictionary<string, string>();
        static string fPrefix;
        const string DefaultPrefix = "SysTable.";

        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        static SysTables()
        {
            Domain = "SYS_DOMAIN";
            Entity = "SYS_ENTITY";

            Ini = "SYS_INI";
            Oid = "SYS_OID";
            Log = "SYS_LOG";

            UserGroup = "SYS_USER_GROUP";
            User = "SYS_USER";

            Data = "SYS_DATA";
            Access = "SYS_ACCESS";
            Company = "SYS_COMPANY";

            Doc = "SYS_DOC";
            DocHist = "SYS_DOC_HIST";

            Lang = "SYS_LANG";
            StrRes = "SYS_STR_RES";

            Action = "SYS_ACTION";
            ActionEntity = "SYS_ACTION_ENTITY";

            SmtpProvider = "SYS_SMTP_PROVIDER";
            CommTemplate = "SYS_COMM_TEMPLATE";
            CommTemplateAsset = "SYS_COMM_TEMPLATE_ASSET";

            CommJob = "SYS_COMM_JOB";
            CommJobItem = "SYS_COMM_JOB_ITEM";
            CommJobAsset = "SYS_COMM_JOB_ASSET";

        }

        /* public */
        /// <summary>
        /// Gets the name of a system table specified by NickName.
        /// <para>NickName SHOULD be one of this class property table names prefixed by Prefix</para>
        /// </summary>
        static public string GetTable(string NickName)
        {
            if (!string.IsNullOrWhiteSpace(NickName))
            {
                if (!NickName.StartsWith(Prefix))
                    NickName = Prefix + NickName;

                if (names.ContainsKey(NickName))
                    return names[NickName];
            }

            return NickName;
        }
        /// <summary>
        /// Returns true if the specified NickName starts with the the Prefix,
        /// the string used to prefix system table names.
        /// </summary>
        static public bool IsPrefixed(string NickName)
        {
            return !string.IsNullOrWhiteSpace(NickName) && NickName.StartsWith(Prefix);
        }


        /* system table names */
        /// <summary>
        /// Gets the name of SYS_DOMAIN system table
        /// <para>Defaults to SYS_DOMAIN</para>
        /// </summary>
        static public string Domain
        {
            get { return names[Prefix + "Domain"]; }
            set { names[Prefix + "Domain"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_ENTITY system table
        /// <para>Defaults to SYS_ENTITY</para>
        /// </summary>
        static public string Entity
        {
            get { return names[Prefix + "Entity"]; }
            set { names[Prefix + "Entity"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_INI system table
        /// <para>Defaults to SYS_INI</para>
        /// </summary>
        static public string Ini
        {
            get { return names[Prefix + "Ini"]; }
            set { names[Prefix + "Ini"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_OID system table
        /// <para>Defaults to SYS_OID</para>
        /// </summary>
        static public string Oid
        {
            get { return names[Prefix + "Oid"]; }
            set { names[Prefix + "Oid"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_LOG system table
        /// <para>Defaults to SYS_LOG</para>
        /// </summary>
        static public string Log
        {
            get { return names[Prefix + "Log"]; }
            set { names[Prefix + "Log"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_USER_GROUP system table
        /// <para>Defaults to SYS_USER_GROUP</para>
        /// </summary>
        static public string UserGroup
        {
            get { return names[Prefix + "UserGroup"]; }
            set { names[Prefix + "UserGroup"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_USER system table
        /// <para>Defaults to SYS_USER</para>
        /// </summary>
        static public string User
        {
            get { return names[Prefix + "User"]; }
            set { names[Prefix + "User"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_DATA system table
        /// <para>Defaults to SYS_DATA</para>
        /// </summary>
        static public string Data
        {
            get { return names[Prefix + "Data"]; }
            set { names[Prefix + "Data"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_ACCESS system table
        /// <para>Defaults to SYS_ACCESS</para>
        /// </summary>
        static public string Access
        {
            get { return names[Prefix + "Access"]; }
            set { names[Prefix + "Access"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_COMPANY system table
        /// <para>Defaults to SYS_COMPANY</para>
        /// </summary>
        static public string Company
        {
            get { return names[Prefix + "Company"]; }
            set { names[Prefix + "Company"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_DOC system table
        /// <para>Defaults to SYS_DOC</para>
        /// </summary>
        static public string Doc
        {
            get { return names[Prefix + "Doc"]; }
            set { names[Prefix + "Doc"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_DOC_HIST system table
        /// <para>Defaults to SYS_DOC_HIST</para>
        /// </summary>
        static public string DocHist
        {
            get { return names[Prefix + "DocHist"]; }
            set { names[Prefix + "DocHist"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_LANG system table
        /// <para>Defaults to SYS_LANG</para>
        /// </summary>
        static public string Lang
        {
            get { return names[Prefix + "Lang"]; }
            set { names[Prefix + "Lang"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_STR_RES system table
        /// <para>Defaults to SYS_STR_RES</para>
        /// </summary>
        static public string StrRes
        {
            get { return names[Prefix + "StrRes"]; }
            set { names[Prefix + "StrRes"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_ACTION system table
        /// <para>Defaults to SYS_ACTION</para>
        /// </summary>
        static public string Action
        {
            get { return names[Prefix + "Action"]; }
            set { names[Prefix + "Action"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_ACTION_ENTITY system table
        /// <para>Defaults to SYS_ACTION_ENTITY</para>
        /// </summary>
        static public string ActionEntity
        {
            get { return names[Prefix + "ActionEntity"]; }
            set { names[Prefix + "ActionEntity"] = value; }
        }



        /// <summary>
        /// Gets the name of SYS_SMTP_PROVIDER system table
        /// <para>Defaults to SYS_SMTP_PROVIDER</para>
        /// </summary>
        static public string SmtpProvider
        {
            get { return names[Prefix + "SmtpProvider"]; }
            set { names[Prefix + "SmtpProvider"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_COMM_TEMPLATE system table
        /// <para>Defaults to SYS_COMM_TEMPLATE</para>
        /// </summary>
        static public string CommTemplate
        {
            get { return names[Prefix + "CommTemplate"]; }
            set { names[Prefix + "CommTemplate"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_COMM_TEMPLATE_ASSET system table
        /// <para>Defaults to SYS_COMM_TEMPLATE_ASSET</para>
        /// </summary>
        static public string CommTemplateAsset
        {
            get { return names[Prefix + "CommTemplateAsset"]; }
            set { names[Prefix + "CommTemplateAsset"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_COMM_JOB system table
        /// <para>Defaults to SYS_COMM_JOB</para>
        /// </summary>
        static public string CommJob
        {
            get { return names[Prefix + "CommJob"]; }
            set { names[Prefix + "CommJob"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_COMM_JOB_ITEM system table
        /// <para>Defaults to SYS_COMM_JOB_ITEM</para>
        /// </summary>
        static public string CommJobItem
        {
            get { return names[Prefix + "CommJobItem"]; }
            set { names[Prefix + "CommJobItem"] = value; }
        }
        /// <summary>
        /// Gets the name of SYS_COMM_JOB_ASSET system table
        /// <para>Defaults to SYS_COMM_JOB_ASSET</para>
        /// </summary>
        static public string CommJobAsset
        {
            get { return names[Prefix + "CommJobAsset"]; }
            set { names[Prefix + "CommJobAsset"] = value; }
        }

        /* miscs */
        /// <summary>
        /// Gets or sets the string used as a prefix
        /// when constructing system table nick-names
        /// </summary>
        static public string Prefix
        {
            get { return string.IsNullOrWhiteSpace(fPrefix) ? DefaultPrefix : fPrefix; }
            set { fPrefix = value; }
        }
        /// <summary>
        /// Gets the dictionary with table names (Alias -> TableName)
        /// </summary>
        static public Dictionary<string, string> Dictionary { get { return names; } }
    }
}
