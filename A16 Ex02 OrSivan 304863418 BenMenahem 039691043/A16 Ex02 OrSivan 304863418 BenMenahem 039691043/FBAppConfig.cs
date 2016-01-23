using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    [Serializable]
    public class FBAppConfig
    {
        private const string k_pathToXml = @"C:\myFBAppConfig.xml";
        
        public string LastAccessToken { get; set; }

        public List<string> EventHostBlacklist { get; set; }

        private FBAppConfig() { EventHostBlacklist = new List<string>(); }

        public void SaveToXml()
        {
            XmlSerializer xsSubmit = new XmlSerializer(this.GetType());
            using (Stream fileStream = new FileStream(k_pathToXml, FileMode.Create))
            {
                xsSubmit.Serialize(fileStream, this);
            }
        }

        private static FBAppConfig initFromXml()
        {
            FBAppConfig appConfig = null;
            XmlSerializer xsSubmit = new XmlSerializer(typeof(FBAppConfig));
            StreamReader fileStream = null;
            try
            {
                fileStream = new StreamReader(k_pathToXml);
                appConfig = (FBAppConfig)xsSubmit.Deserialize(fileStream);
            }
            catch (Exception e)
            {
                appConfig = new FBAppConfig();
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }

            return appConfig;
        }
    }
}
