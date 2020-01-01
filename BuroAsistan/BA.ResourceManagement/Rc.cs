using System;

namespace BA.ResourceManagement
{
    public class Rc
    {
        public static string GetString(string resource)
        {
            try
            {
                return RESOURCES.ResourceManager.GetString(string.Format("RC_{0}", resource));
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}