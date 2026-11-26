using DVLD_Business;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace DVLD.Global_Classes
{
    internal class clsGlobal
    {
        public static clsUser CurrentUser;
        private const string RegistryPath = @"Software\DVLD";

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            try
            {
                if (string.IsNullOrEmpty(Username))
                {
                    Registry.CurrentUser.DeleteSubKeyTree(RegistryPath, false);
                    return true;
                }

                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
                {
                    if (key != null)
                    {
                        key.SetValue("Username", Username);
                        key.SetValue("Password", Password);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
                {
                    if (key == null)
                        return false;

                    object userValue = key.GetValue("Username");
                    object passValue = key.GetValue("Password");

                    if (userValue == null || passValue == null)
                        return false;

                    Username = userValue.ToString();
                    Password = passValue.ToString();
                    if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                        return false;

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}