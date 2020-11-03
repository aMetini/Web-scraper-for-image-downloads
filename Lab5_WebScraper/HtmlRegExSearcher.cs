using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab5_WebScraper
{
    class HtmlRegExSearcher
    {
        public string HtmlData { get; }

        public HtmlRegExSearcher(string htmlData)
        {
            HtmlData = htmlData;
        }

        public List<string> GetImages()
        {
            string pattern = "<img .*?(.*?)>";
            List<string> images = new List<string>();

            foreach(Match match in Regex.Matches(HtmlData, pattern))
            {
                string srcPattern = "src.*=.*?(.*?)\"";
                string imageSrc = Regex.Match(match.ToString(), srcPattern).ToString();

                if (imageSrc.Contains("src") && imageSrc.Contains('='))
                {
                    string urlPattern = "\".*?(.*?)\"";
                    string imageSrcURL = Regex.Match(imageSrc, urlPattern).ToString().Replace("\"", "");
                    images.Add(imageSrcURL);
                }
            }
            return images;
        }
    }
}
