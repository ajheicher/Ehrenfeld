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
            //timezone problems?
            publishedDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);

            refURL = "http://10.171.1.100/ccp-webapp/ccp/socialcontact/" + scID;

            createTranscriptLL();
            returnBaseData();
        }

        public SocialContact(string sm, string id, bool noTranscript)
        {
            socialMinerCredentials = sm;
            scID = id;
            //timezone problems?
            publishedDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);

            refURL = "http://10.171.1.100/ccp-webapp/ccp/socialcontact/" + scID;

            //createTranscriptLL();
            returnBaseData();
        }

        public override string ToString()
        {
            //returnBaseData();
            return solicitor + " - " + publishedDate.ToString();
        }

        public void returnBaseData()
        {           
            
            //create WebRequest
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(refURL);

            //Request method
            httpWebRequest.Method = "GET";

            //Add auth header
            httpWebRequest.Headers.Add("Authorization", "Basic " + socialMinerCredentials);

            //Make web request
            using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                raw = reader.ReadToEnd();

            }
            //Parse XML using XML reader
            //TODO: expand LINQ -> XML
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
                            XElement element = XNode.ReadFrom(reader) as XElement;
                            publishedDate = publishedDate.AddMilliseconds(Double.Parse(element.Value)).ToLocalTime();
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
                                                //Console.WriteLine(subInner.Value);
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
                            //Console.WriteLine(reader.Name);
                            status = (scSocialContactStatus)3;
                        }
                    }
                }

                



                }
            }
        
        /// <summary>
        /// Builds the transcript by making an API request to the SocialMiner server 
        /// and splitting the result into individual transcript entries
        /// These entries are added to a linkedlist in social contact and hold the transcript data
        /// TODO: This is so bad, make it better by
        /// TODO: Make the XML parsing more explicit
        /// TODO: Standardize the refURL
        /// TODO: Figure out why "No transcript" isn't working
        /// TODO: Potentially insert reference to nebulous "make request" function to improve code duplicate problems
        /// </summary>
        public void createTranscriptLL()
        {
            //API call
            string transcriptRefUrl = refURL + "/transcript";
            
            //Transcript entry component variables
            double tempTimestamp;
            string tempName;
            string tempBody;

            //***************Begin Web Request Block***************\\
            //create WebRequest
            Console.WriteLine(transcriptRefUrl);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(transcriptRefUrl);

            //Request method
            httpWebRequest.Method = "GET";

            //Add auth header
            httpWebRequest.Headers.Add("Authorization", "Basic " + socialMinerCredentials);

            //TODO: Figure out why a missing transcript returns a 404 instead of the API errors thing
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    raw = reader.ReadToEnd();

                }
            }
            catch (WebException ex)
            { 
               
                Console.WriteLine("404!");
                transcript.AddLast(new TranscriptEntry(0, "No Name", "No Transcript"));
                return;
                
            }

            //***************End Web Request Block***************\\

            //***************Begin XML Parsing Block*************\\

            using (XmlReader reader = XmlReader.Create(new StringReader(raw)))
            {
                //TODO: make this better
                while (true)
                {
                    if (reader.ReadToFollowing("chat"))
                    {
                        XmlReader inner = reader.ReadSubtree();

                        inner.ReadToDescendant("time");
                        tempTimestamp = inner.ReadElementContentAsDouble();
                        //Console.WriteLine(tempTimestamp);
                        
                        //reader.Read();
                        
                        tempName = inner.ReadElementContentAsString();
                        //Console.WriteLine(tempName);

                        //reader.Read();
                        tempBody = inner.ReadElementContentAsString();
                        //Console.WriteLine(tempBody);

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
                    else if (reader.ReadToFollowing("apiErrors"))
                    {
                        transcript.AddLast(new TranscriptEntry(0, "No Name", "No Transcript"));
                    }
                    else
                    {
                        break;
                    }

                    
                }
            }
            //***************End XML Parsing Block***************\\

            //Begin test block
            //XDocument xDoc = XDocument.Load(raw);


        }

        /// <summary>
        /// Method to check if a chat is QAAble
        /// QAAble is defined as a chat that can be applied to an agent's QA score
        /// Such chats include a transcript and an actual exchange between the guest and the agent
        /// Programmatically, this is defined as having more than two transcript entries
        /// </summary>
        /// <returns></returns>
        public bool isQAAble()
        {
            return (transcript.Count > 2);
        }
    }
}
