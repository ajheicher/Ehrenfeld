using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMinerTestFormsApp
{
    public enum scSocialContactStatus {Unread, Reserved, Draft, Handled, Discarded, Queued};
    public class SocialContact
    {
        public string solicitor { get; set;  }
        public string ccxName { get; set; }
        public string ccxEmail { get; set; }
        public string ccxCSQ { get; set; }
        public string refURL { get; set; }

        public string raw;
        public DateTime publishedDate { get; set; }
        public string socialMinerCredentials { get; set; }
        public scSocialContactStatus status { get; set; }

        public LinkedList<TranscriptEntry> transcript = new LinkedList<TranscriptEntry>();
        public string scID { get; set; }



        public SocialContact(string sm, string id)
        {
            socialMinerCredentials = sm;
            scID = id;
            publishedDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);

            refURL = "http://10.171.1.100/ccp-webapp/ccp/socialcontact/" + scID;

            createTranscriptLL();
            returnBaseData();
        }

        public void returnBaseData()
        {           
            
            //create WebRequest
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(refURL);

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
            using (XmlReader reader = XmlReader.Create(new StringReader(raw)))
            {
                //TODO: Add exception handling and bad response handling

                //reader.MoveToContent();

                while(reader.Read())
                {
                    
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        
                        if (reader.Name == "createdDate")
                        {
                            //Console.WriteLine(reader.Name);
                            //Console.WriteLine(reader.Value);
                            //publishedDate = publishedDate.AddMilliseconds(Double.Parse(reader.Value)).ToLocalTime();
                        }
                        if (reader.Name == "extensionFields")
                        {
                            XmlReader inner = reader.ReadSubtree();

                            while (inner.Read())
                            {
                                //Console.WriteLine(inner.Name + "<--should be efs");
                                if (reader.Name == "extensionField")
                                {
                                    //Console.WriteLine(inner.Name + "<--should be ef");
                                    XmlReader subInner = inner.ReadSubtree();

                                    while (subInner.Read())
                                    {
                                        if (reader.Name == "name")
                                        {
                                            XElement element = XNode.ReadFrom(subInner) as XElement;
                                            string elementString = element.Value;
                                            //Console.WriteLine(elementString);
                                            //Console.WriteLine(subInner.Name + "<--should be name");
                                            //Console.WriteLine(subInner.Value + "<--should be value");
                                            if (elementString == "Email")
                                            {
                                                subInner.Read();
                                                Console.WriteLine(subInner.Value);
                                               // XElement tempElement = XNode.ReadFrom(subInner) as XElement;
                                                ccxEmail = subInner.Value;
                                            }

                                            if (elementString == "ccxqueuetag")
                                            {
                                                //Console.WriteLine(subInner.Value + "<--should be value");
                                               
                                                subInner.Read();
                                                //XElement tempElement = XNode.ReadFrom(subInner) as XElement;
                                                ccxCSQ = subInner.Value;
                                            }

                                            if (elementString == "h_Name")
                                            {
                                                subInner.Read();
                                               // XElement tempElement = XNode.ReadFrom(subInner) as XElement;
                                                ccxName = subInner.Value;
                                            }

                                            if (elementString == "h_agentName")
                                            {
                                                subInner.Read();
                                               // XElement tempElement = XNode.ReadFrom(subInner) as XElement;
                                                solicitor = subInner.Value;
                                            }
                                        }
                                    }
                                }
                            }

                                
                        
                        }
                        
                        
                        if (reader.Name == "status")
                        {
                            Console.WriteLine(reader.Name);
                            status = (scSocialContactStatus)1;
                        }
                    }
                }

                



                }
            }
        

        public void createTranscriptLL()
        {
            string transcriptRefUrl = refURL + "/transcript";
            double tempTimestamp;
            string tempName;
            string tempBody;
          
            
            //create WebRequest
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(transcriptRefUrl);

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

            
                
            using (XmlReader reader = XmlReader.Create(new StringReader(raw)))
            {
                while (true)
                {
                    if (reader.ReadToFollowing("chat"))
                    {
                        XmlReader inner = reader.ReadSubtree();

                        inner.ReadToDescendant("time");
                        tempTimestamp = inner.ReadElementContentAsDouble();
                        Console.WriteLine(tempTimestamp);
                        
                        //reader.Read();
                        
                        tempName = inner.ReadElementContentAsString();
                        Console.WriteLine(tempName);

                        //reader.Read();
                        tempBody = inner.ReadElementContentAsString();
                        Console.WriteLine(tempBody);

                        if (transcript.Last == null)
                        {
                            transcript.AddLast(new TranscriptEntry(tempTimestamp, tempName, tempBody));
                        }
                        else
                        {
                            transcript.AddAfter(transcript.Last, new TranscriptEntry(tempTimestamp, tempName, tempBody));
                        }
                        inner.Close();
                    }
                    else
                    {
                        break;
                    }

                    
                }
            }
        }
    }
}
