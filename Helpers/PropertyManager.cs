using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YTR.Helpers
{
    public static class MyPropertyManager
    {
        public static void SetProperty(string name, object value)
        {
            Properties.Settings.Default[name] = value;
            Properties.Settings.Default.Save();
        }

        public static object GetProperty(string name)
        {
            try
            {
                return Properties.Settings.Default[name];
            }
            catch
            {
                return null;
            }
        }

        public static void OnLoad()
        {
            Properties.Settings.Default.Upgrade();
        }
    }

}
