namespace BA.Configuration
{
    using System;
    using System.Collections;
    using System.Xml;

    public class ApplicationSettings
    {
        private static readonly string conf_file_path = @"C:\FreeORM\config\conf.xml";
        private Hashtable h;
        XmlDocument xmlDoc;
        XmlNodeList xmlNodes;

        public ApplicationSettings()
        {
            h = GetHash();
        }

        public object this[string key]
        {
            get { return h[key]; }
        }

        public object GetValue(string key)
        {
            try
            {
                return h[key];
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Hashtable GetHash()
        {
            try
            {
                Hashtable ht = new Hashtable();
                xmlDoc = new XmlDocument();
                xmlDoc.Load(conf_file_path);

                #region [ App Settings ]

                try
                {
                    XmlNode node = xmlDoc.SelectSingleNode("appsettings/current-culture");
                    ht.Add(node.Name, node.InnerText);
                }
                catch (Exception)
                { }

                #endregion

                #region [ App Config Ayarları ]
                try
                {
                    xmlNodes = xmlDoc.SelectNodes("appsettings/appconfig/log-setting");
                    foreach (XmlNode node in xmlNodes)
                    {
                        ht.Add(node.Name, node.InnerText);
                    }
                }
                catch (Exception)
                { }
                #endregion

                #region [ Log Ayarları ]

                try
                {
                    xmlNodes = xmlDoc.SelectNodes("appsettings/appconfig/log-setting");
                    foreach (XmlNode xml_node in xmlNodes)
                    {
                        if (xml_node.HasChildNodes == true)
                        {
                            foreach (XmlNode node in xml_node.ChildNodes)
                            {
                                ht.Add(node.Name, node.InnerText);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }

                #endregion

                #region [ Picture Settings ]

                try
                {
                    xmlNodes = xmlDoc.SelectNodes("appsettings/appconfig/picture-settings");
                    foreach (XmlNode xml_node in xmlNodes)
                    {
                        if (xml_node.HasChildNodes == true)
                        {
                            foreach (XmlNode node in xml_node.ChildNodes)
                            {
                                ht.Add(node.Name, node.InnerText);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }

                #endregion

                return ht;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
