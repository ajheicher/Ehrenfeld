using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMinerTestFormsApp
{
    public class TranscriptEntry
    {
        public double entryTimestamp { get; }
        public string entryName { get; }
        public string entryBody { get; }

        public TranscriptEntry(double ts, string name, string body)
        {
            entryTimestamp = ts;
            entryName = name;
            entryBody = body;
        }

        public string toString()
        {
            return "[" + entryName + " @ " + entryTimestamp + "]: " + entryBody;
        }
    }
}
