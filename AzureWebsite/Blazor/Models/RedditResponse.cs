using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using AzureWebsite.Utilities;

namespace AzureWebsite.Blazor.Models
{
    public class RedditResponse
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public List<RedditFeedModel> Items { get; set; }

        public RedditResponse(XElement response)
        {
            var ns = response.Name.Namespace;
            //var channel = response.Element("channel");
            //if (channel == null) throw new Exception("Unexpected xml");

            Title = (string)response.Element(ns +"title");
            Link = (string)response.Element(ns +"link");
           
            //Console.WriteLine((string)response.Element(ns +"category"));


            Items = new List<RedditFeedModel>();
            foreach (var item in response.Descendants(ns + "entry" ))
            {
                Items.Add(new RedditFeedModel(item, ns));
            }
        }
    }
}
