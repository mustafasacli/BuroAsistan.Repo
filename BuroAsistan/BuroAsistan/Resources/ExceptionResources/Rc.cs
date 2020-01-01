using System;

namespace BuroAsistan.Resources.ExceptionResources
{
    internal class Rc
    {
        public static string GetString(string key)
        {
            string res = string.Empty;
            try
            {
                res = RESOURCES.ResourceManager.GetString(string.Format("RC_{0}", key));
            }
            catch (Exception)
            {
                res = "App Resource Fail.";
            }
            return res;
        }
    }
}