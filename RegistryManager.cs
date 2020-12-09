using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace LSRVersionManager
{
    public class RegistryManager
    {
        public RegistryKey key;

        public RegistryManager()
        {
            try
            {
                key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\LEGO Media\LEGO Stunt Rally", true);
                if (key == null) key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\LEGO Media\LEGO Stunt Rally", true);
            }
            catch (SecurityException)
            {
                MessageBox.Show("I don't have permission to edit registry keys! Try opening with Administrator?", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        public object ReadKey(string keyName)
        {
            return key?.GetValue(keyName);
        }

        public void WriteKey(string keyName, object value)
        {
            key?.SetValue(keyName, value);
        }
    }
}
