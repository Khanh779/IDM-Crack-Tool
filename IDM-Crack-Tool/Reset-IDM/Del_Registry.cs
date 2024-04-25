using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDM_Crack_Tool.Reset_IDM
{
    public class Del_Registry
    {
        public static void DeleteRegistryKey(string root, string subKey)
        {
            try
            {
                RegistryKey baseKey = root == "HKEY_CURRENT_USER" ? Registry.CurrentUser : Registry.LocalMachine;
                RegistryKey key = baseKey.OpenSubKey(subKey, writable: true);
                if (key != null)
                {
                    baseKey.DeleteSubKeyTree(subKey);
                    Console.WriteLine($"Deleted: {root}\\{subKey}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting {root}\\{subKey}: {ex.Message}");
            }
        }

        public static void DeleteRegistryValue(string root, string subKey, string valueName)
        {
            try
            {
                RegistryKey baseKey = root == "HKEY_CURRENT_USER" ? Registry.CurrentUser : Registry.LocalMachine;
                RegistryKey key = baseKey.OpenSubKey(subKey, writable: true);
                if (key != null)
                {
                    key.DeleteValue(valueName, false);
                    Console.WriteLine($"Deleted value: {root}\\{subKey}\\{valueName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting value {root}\\{subKey}\\{valueName}: {ex.Message}");
            }
        }
    }
}
