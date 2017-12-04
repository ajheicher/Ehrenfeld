using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LemmaSharp;

namespace SocialMinerTestFormsApp
{
    public class Wordcloud
    {
        public Regex wordFinder = new Regex(@"[\w\']+", RegexOptions.Compiled);
        public Lemmatizer lemmatizer = new LemmatizerPrebuiltCompact(LanguagePrebuilt.English);
        public HashSet<string> stopWords = loadStopWords();
        public int maxCloudSize = 100;
        public int numCategories = 10;

        public List<string> cloudSeed;


        public Wordcloud ()
        {
        }

        public IEnumerable<CloudWord> createWordCloud(IEnumerable<string> chats)
        {
            var dict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            processChatToWords(chats, dict);
            return sortAndFilter(dict).ToArray();
            
        }

        private IEnumerable<CloudWord> sortAndFilter(Dictionary<string,int> dict)
        {
            var total = Math.Min(maxCloudSize, dict.Count);
            var div = Math.Max(1, total / numCategories);
            var index = 0;

            foreach (var word in stopWords) { Console.WriteLine(word); }

            return dict.OrderByDescending(p => p.Value)
                .Where(p => !stopWords.Contains(p.Key.ToLower().Trim()))
                .Take(maxCloudSize)
                .Select(p => new CloudWord()
                {
                    Text = p.Key.Replace('+', ' '),
                    Count = p.Value,
                    Category = (index++) / div
                });
                
        }

        private void processChatToWords(IEnumerable<string> chats, Dictionary<string,int> dict)
        {
            foreach (var chat in chats)
            {
                //removeChatArtifacts(chat, dict);
                countWords(chat, dict);
            }
        }
        /// <summary>
        /// This method remove the PREDEFINED RESPONSES
        /// </summary>
        /// <param name="chat"></param>
        /// <param name="dict"></param>
        private void removeChatArtifacts(string chat, Dictionary<string, int> dict)
        {
           //todo: have this do something
        }

        private void countWords(string scrubbedChat, Dictionary<string, int> dict)
        {
            var words = wordFinder.Matches(scrubbedChat)
                .Cast<Match>()
                .Select(m => lemmatizer.Lemmatize(m.Value));

            foreach (var word in words)
            {
                var tword = word.ToLower().Trim();
                int count = 0;
                dict.TryGetValue(tword, out count);
                ++count;
                dict[tword] = count;
            }
        }

        private static HashSet<string> loadStopWords()
        {
            var wordList = SocialMinerTestFormsApp.Properties.Resources.stopWords.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            //for (int x = 0; x < wordList.Length; x++) { wordList[x] = wordList[x].Trim(); }

            return new HashSet<string>(wordList, StringComparer.OrdinalIgnoreCase);

        }

    }
}
