using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SocialMinerTestFormsApp
{
    public class Campaign
    {
        public string campaignName { get; }
        public string campaignRefURL { get; }
        public int campaignTotalCount { get; }
        public string rawXML { get; }

        public string socialMinerCredentials;

        public StringBuilder output = new StringBuilder();

        public SocialContact[] resultResults;


        public Campaign(string sm, string refURL)
        {
            socialMinerCredentials = sm;
            campaignRefURL = refURL;
            rawXML = getRawCampaignXML();
            campaignTotalCount = countTotalCampaignChats();
            output = parseCampsignXML(rawXML);
            output.Append("Total Chats Across Campaign: " + campaignTotalCount);
            
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

        private int countTotalCampaignChats()
        {
            //create WebRequest
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(campaignRefURL + "count");

            //Request method
            httpWebRequest.Method = "GET";

            //Add auth header
            httpWebRequest.Headers.Add("Authorization", "Basic " + socialMinerCredentials);

            using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                using (XmlReader xReader = XmlReader.Create(new StringReader(reader.ReadToEnd())))
                {
                    xReader.MoveToContent();
                    Console.WriteLine(xReader.Value);
                    return Convert.ToInt32(xReader.ReadElementContentAsString());
                }
            }
        }

        public string newSearchStringByDate(DateTime start, DateTime end)
        {
            return "sc.createdDate:[" + start.ToString("s") + "Z%20TO%20" + end.ToString("s") + "Z]";
        }

        public List<SocialContact> newSearch(string query)
        {
            string raw;
            int totalResultsFetched;
            int totalResults;
            int thisPageResults;
            List<SocialContact> returnSet = new List<SocialContact>();
            //create WebRequest
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://10.171.1.100/ccp-webapp/ccp/search/contacts?q=" + query + "&count=200");
            StringBuilder builtString = new StringBuilder();

            //Request method
            httpWebRequest.Method = "GET";

            //Add auth header
            httpWebRequest.Headers.Add("Authorization", "Basic " + socialMinerCredentials);

            using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                raw = reader.ReadToEnd();
            }


            using (XmlReader xReader = XmlReader.Create(new StringReader(raw)))
            {
                xReader.ReadToFollowing("opensearch:itemsPerPage");
                
                XElement element = XNode.ReadFrom(xReader) as XElement;
                totalResultsFetched = Convert.ToInt32(element.Value);

               
                thisPageResults = Convert.ToInt32(element.Value);
                xReader.ReadToFollowing("opensearch:totalResults");
                element = XNode.ReadFrom(xReader) as XElement;
                totalResults = Convert.ToInt32(element.Value);

                while(xReader.Read())
                {
                    if (xReader.NodeType == XmlNodeType.Element)
                    {
                        if (xReader.Name == "entry")
                        {
                            XmlReader inner = xReader.ReadSubtree();

                            while(inner.Read())
                            {
                                if (inner.Name == "content")
                                {
                                    XmlReader subInner = inner.ReadSubtree();

                                    while(subInner.Read())
                                    {
                                        if (subInner.Name == "id")
                                        {
                                            element = XNode.ReadFrom(inner) as XElement;
                                            returnSet.Add(new SocialContact(socialMinerCredentials, element.Value));
                                        }
                                    }
                                    
                                }
                               
                            }
                        }
                    }
                }

               
   
            }

            return returnSet;
        }
    }
    
}
