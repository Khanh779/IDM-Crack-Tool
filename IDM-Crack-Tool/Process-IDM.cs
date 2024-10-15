using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IDM_Crack_Tool.Reset_IDM.Del_Registry;

namespace IDM_Crack_Tool
{
    public class Process_IDM
    {
        public static void DeleteRegistryIDMKey()
        {
            // Deleting keys Registry
            DeleteRegistryKey("HKEY_CURRENT_USER", "Software\\Classes\\CLSID\\{7B8E9164-324D-4A2E-A46D-0165FB2000EC}");
            DeleteRegistryKey("HKEY_CURRENT_USER", "Software\\Classes\\Wow6432Node\\CLSID\\{7B8E9164-324D-4A2E-A46D-0165FB2000EC}");
            DeleteRegistryKey("HKEY_LOCAL_MACHINE", "Software\\Classes\\CLSID\\{7B8E9164-324D-4A2E-A46D-0165FB2000EC}");
            DeleteRegistryKey("HKEY_LOCAL_MACHINE", "Software\\Classes\\Wow6432Node\\CLSID\\{7B8E9164-324D-4A2E-A46D-0165FB2000EC}");

            DeleteRegistryKey("HKEY_CURRENT_USER", "Software\\Classes\\CLSID\\{6DDF00DB-1234-46EC-8356-27E7B2051192}");
            DeleteRegistryKey("HKEY_CURRENT_USER", "Software\\Classes\\Wow6432Node\\CLSID\\{6DDF00DB-1234-46EC-8356-27E7B2051192}");
            DeleteRegistryKey("HKEY_LOCAL_MACHINE", "Software\\Classes\\CLSID\\{6DDF00DB-1234-46EC-8356-27E7B2051192}");
            DeleteRegistryKey("HKEY_LOCAL_MACHINE", "Software\\Classes\\Wow6432Node\\CLSID\\{6DDF00DB-1234-46EC-8356-27E7B2051192}");

            DeleteRegistryKey("HKEY_CURRENT_USER", "Software\\Classes\\CLSID\\{D5B91409-A8CA-4973-9A0B-59F713D25671}");
            DeleteRegistryKey("HKEY_CURRENT_USER", "Software\\Classes\\Wow6432Node\\CLSID\\{D5B91409-A8CA-4973-9A0B-59F713D25671}");
            DeleteRegistryKey("HKEY_LOCAL_MACHINE", "Software\\Classes\\CLSID\\{D5B91409-A8CA-4973-9A0B-59F713D25671}");
            DeleteRegistryKey("HKEY_LOCAL_MACHINE", "Software\\Classes\\Wow6432Node\\CLSID\\{D5B91409-A8CA-4973-9A0B-59F713D25671}");

            DeleteRegistryKey("HKEY_CURRENT_USER", "Software\\Classes\\CLSID\\{5ED60779-4DE2-4E07-B862-974CA4FF2E9C}");
            DeleteRegistryKey("HKEY_CURRENT_USER", "Software\\Classes\\Wow6432Node\\CLSID\\{5ED60779-4DE2-4E07-B862-974CA4FF2E9C}");
            DeleteRegistryKey("HKEY_LOCAL_MACHINE", "Software\\Classes\\CLSID\\{5ED60779-4DE2-4E07-B862-974CA4FF2E9C}");
            DeleteRegistryKey("HKEY_LOCAL_MACHINE", "Software\\Classes\\Wow6432Node\\CLSID\\{5ED60779-4DE2-4E07-B862-974CA4FF2E9C}");

            DeleteRegistryKey("HKEY_CURRENT_USER", "Software\\Classes\\CLSID\\{07999AC3-058B-40BF-984F-69EB1E554CA7}");
            DeleteRegistryKey("HKEY_CURRENT_USER", "Software\\Classes\\Wow6432Node\\CLSID\\{07999AC3-058B-40BF-984F-69EB1E554CA7}");
            DeleteRegistryKey("HKEY_LOCAL_MACHINE", "Software\\Classes\\CLSID\\{07999AC3-058B-40BF-984F-69EB1E554CA7}");
            DeleteRegistryKey("HKEY_LOCAL_MACHINE", "Software\\Classes\\Wow6432Node\\CLSID\\{07999AC3-058B-40BF-984F-69EB1E554CA7}");

            // Deleting values in Registry
            DeleteRegistryValue("HKEY_CURRENT_USER", "Software\\DownloadManager", "FName");
            DeleteRegistryValue("HKEY_CURRENT_USER", "Software\\DownloadManager", "LName");
            DeleteRegistryValue("HKEY_CURRENT_USER", "Software\\DownloadManager", "Email");
            DeleteRegistryValue("HKEY_CURRENT_USER", "Software\\DownloadManager", "Serial");

            DeleteRegistryValue("HKEY_LOCAL_MACHINE", "Software\\Internet Download Manager", "FName");
            DeleteRegistryValue("HKEY_LOCAL_MACHINE", "Software\\Wow6432Node\\Internet Download Manager", "FName");
            DeleteRegistryValue("HKEY_LOCAL_MACHINE", "Software\\Internet Download Manager", "LName");
            DeleteRegistryValue("HKEY_LOCAL_MACHINE", "Software\\Wow6432Node\\Internet Download Manager", "LName");
            DeleteRegistryValue("HKEY_LOCAL_MACHINE", "Software\\Internet Download Manager", "Email");
            DeleteRegistryValue("HKEY_LOCAL_MACHINE", "Software\\Wow6432Node\\Internet Download Manager", "Email");
            DeleteRegistryValue("HKEY_LOCAL_MACHINE", "Software\\Internet Download Manager", "Serial");
            DeleteRegistryValue("HKEY_LOCAL_MACHINE", "Software\\Wow6432Node\\Internet Download Manager", "Serial");
        }

        public static bool CheckInstalledIDM()
        {
            // Đường dẫn registry để kiểm tra xem IDM đã cài đặt chưa
            string[] idmRegistryPaths =
            {
                @"Software\Internet Download Manager",
                @"Software\Wow6432Node\Internet Download Manager"
            };

            ;
            string filePath = Environment.GetFolderPath(Environment.Is64BitOperatingSystem ? Environment.SpecialFolder.ProgramFilesX86 : Environment.SpecialFolder.ProgramFiles)
                + @"\Internet Download Manager\IDMan.exe";

            bool isIDMInstalled = false;

            foreach (string path in idmRegistryPaths)
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path))
                {
                    if (key != null)
                    {
                        isIDMInstalled = true;
                        break;
                    }
                }
            }

            return isIDMInstalled && System.IO.File.Exists(filePath);
        }

        public static string GetVersionIDM()
        {
            string version = "N/A";
            try
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Internet Download Manager");
                if (key != null)
                {
                    version = key.GetValue("Version").ToString();
                }
            }
            catch (Exception ex)
            {
                version = "Error:\n"+ex;
            }
            return version;
        }

        public static string GetDaysRemain()
        {
            string idmRegistryPath = @"Software\Internet Download Manager";
            string dateRemain = string.Empty;
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(idmRegistryPath))
                {
                    if (key != null)
                    {
                        
                        // Kiểm tra giá trị "ExpirationDate" để xác định ngày hết hạn dùng thử (nếu có)
                        string expirationDateStr = key.GetValue("ExpirationDate") as string;

                        if (!string.IsNullOrEmpty(expirationDateStr))
                        {
                            DateTime expirationDate;
                            if (DateTime.TryParse(expirationDateStr, out expirationDate))
                            {
                                TimeSpan remainingDays = expirationDate - DateTime.Now;
                                if (remainingDays.Days > 0)
                                {
                                    dateRemain = remainingDays.Days.ToString();
                                }
                            }
                        }
                    }
                    else
                    {
                        dateRemain = "Error";
                    }
                }
            }
            catch (Exception ex)
            {
                dateRemain = ex.Message;
            }
            return dateRemain;
        }

        public static string GetActivationStatus()
        {
            string idmRegistryPath = @"Software\Internet Download Manager";
            string activationStatus = string.Empty;
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(idmRegistryPath))
                {
                    if (key != null)
                    {
                        // Kiểm tra giá trị "Serial" trong registry để xác định trạng thái kích hoạt
                        string serial = key.GetValue("Serial") as string;

                        if (!string.IsNullOrEmpty(serial))
                        {
                            activationStatus = "Activated";
                        }
                        else
                        {
                            activationStatus = "Not Activated";
                        }

                    }
                    else
                    {
                        activationStatus="Error";
                    }
                }
            }
            catch (Exception ex)
            {
               activationStatus= "Error";
            }
            return activationStatus;
        }

        public static void CrackIDM()
        {
            try
            {
                // Step 1: Check if IDM is installed
                var idmPath = GetIDMPath();
                if (idmPath == null)
                {
                    Console.WriteLine("IDM is not installed.");
                    return;
                }

                // Step 2: Ensure we have administrator rights
                //EnsureAdminRights();

                // Step 3: Activate IDM by modifying registry keys
                ActivateIDM();

                Console.WriteLine("IDM activated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during activation: {ex.Message}");
            }
        }

        private static string GetIDMPath()
        {
            // Checking if IDM is installed by querying registry
            using (var key = Registry.CurrentUser.OpenSubKey("Software\\DownloadManager"))
            {
                if (key != null)
                {
                    return key.GetValue("ExePath") as string;
                }
            }

            return null;
        }

        public static void EnsureAdminRights()
        {
            // If not running with admin rights, elevate process
            if (!IsAdministrator())
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = Process.GetCurrentProcess().MainModule.FileName,
                    Verb = "runas", // Run as administrator
                    UseShellExecute = true
                };

                Process.Start(startInfo);
                Environment.Exit(0); // Exit current process after elevation
            }
        }

        public static bool IsAdministrator()
        {
            // Check if running with admin rights
            using (var identity = System.Security.Principal.WindowsIdentity.GetCurrent())
            {
                var principal = new System.Security.Principal.WindowsPrincipal(identity);
                return principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }
        }

        static string[] licenses ={ "XO6HF-VTUS8-3B7KY-D24LG"};

        static string[] emails = { "info@tonec.com", "info@idm.com" };

        private static void ActivateIDM()
        {
            //string[] valuesToRead = new string[]
            //           {
            //                "FName",
            //                "LName",
            //                "Email",
            //                "Serial",
            //                "scansk",
            //                "tvfrdt",
            //                "radxcnt",
            //                "LstCheck",
            //                "ptrk_scdt",
            //                "LastCheckQU"
            //           };

            // Modify registry keys to activate IDM
            using (var key = Registry.CurrentUser.CreateSubKey("Software\\DownloadManager"))
            {
                key.SetValue("FName", Environment.UserName);
                key.SetValue("LName", "");
                key.SetValue("Email", emails[0]);
                key.SetValue("Serial", licenses[0]);
            }
        }

    }
}
