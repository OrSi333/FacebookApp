using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace A16_Ex01_OrSivan_304863418_BenMenahem_039691043
{
    [Serializable]
    public class FBAppConfig
    {
        private const string k_pathToXml = @"C:\xml.xml";
        
        public string LastAccessToken { get; set; }

        private FBAppConfig() { }

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
