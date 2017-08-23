using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SocialMinerTestFormsApp
{
    class Campaign
    {
        public string campaignName { get; }
        public string campaignRefURL { get; }
        public string campaignTotalCount { get; }
        public string rawXML { get; }

        public string socialMinerCredentials;

        public StringBuilder output = new StringBuilder();


        public Campaign(string sm, string refURL)
        {
            socialMinerCredentials = sm;
            campaignRefURL = refURL;
            rawXML = getRawCampaignXML();
            output = parseCampsignXML(rawXML);
        }

        public string getRawCampaignXML()
        {
            //create WebRequest
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(campaignRefURL);

            //Request method
            httpWebRequest.Method = "GET";

            //Add auth header
            httpWebRequest.Headers.Add("Authorization", "Basic " + socialMinerCredentials);

            using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private StringBuilder parseCampsignXML(string xml)
        {
            StringBuilder builtString = new StringBuilder();
            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                //parse to first campaign
                //TODO: Check for chat campaign
                //TODO: Refactor into object-oriented, this isn't LISP you jabronie
                reader.ReadToFollowing("Campaign");
                reader.ReadToDescendant("name");
                builtString.AppendLine("Campaign Title: " + reader.ReadElementContentAsString());

                //Get References URL
                reader.ReadToNextSibling("refURL");
                builtString.AppendLine("Campaign API Reference URL: " + reader.ReadElementContentAsString());

                return builtString;
            }
        }
    }
}
