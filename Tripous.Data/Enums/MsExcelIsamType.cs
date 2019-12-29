/*--------------------------------------------------------------------------------------        
                           Copyright © 2018 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/


using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tripous.Data
{

 
    /// <summary>
    /// Indicates the MsExcel ISAM format type
    /// 
    /// HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Jet\4.0\ISAM Formats
    /// HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Jet\4.0\ISAM Formats
    /// HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Office\12.0\Access Connectivity Engine\ISAM Formats
    /// HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Office\14.0\Access\Access Connectivity Engine\ISAM Formats
    /// HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Office\14.0\Access Connectivity Engine\ISAM Formats
    /// </summary>
    [Flags]
    public enum MsExcelIsamType
    {
        /// <summary>
        /// None
        /// </summary>
        None = 0,
        /// <summary>
        /// Extended Properties=Excel 8.0
        /// </summary>
        Excel8 = 2,
        /// <summary>
        /// Extended Properties=Excel 12.0
        /// </summary>
        Excel12 = 4,
    }


}