
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCompletionClassGenerator
{
    
    internal static class DsnGetter{
        public static string[] GetDsn()
        {
            const string DSN_PATH = @"Software\ODBC\ODBC.INI\ODBC Data Sources";
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(DSN_PATH);
            return rk.GetValueNames();
        }
    }
}