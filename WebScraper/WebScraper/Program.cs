using HtmlAgilityPack;
using System;
using System.Linq;
using System.Net.Http;

namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            GetHtmlAsync();
            Console.ReadLine();
        }
        private static void GetHtmlAsync()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.ebay.com/sch/i.html?_from=R40&_nkw=surface+book+2&_in_kw=1&_ex_kw=&_sacat=0&LH_Complete=1&_udlo=&_udhi=&_samilow=&_samihi=&_sadis=15&_stpos=98106&_sargn=-1%26saslc%3D1&_salic=1&_sop=12&_dmd=1&_ipg=50&_fosrp=1");
            foreach (var item in doc.DocumentNode.SelectNodes("//a[@class='vip']"))
            {
                Console.WriteLine(item.InnerText);
            }


            //    var url = "https://www.ebay.com/sch/i.html?_from=R40&_nkw=surface+book+2&_in_kw=1&_ex_kw=&_sacat=0&LH_Complete=1&_udlo=&_udhi=&_samilow=&_samihi=&_sadis=15&_stpos=98106&_sargn=-1%26saslc%3D1&_salic=1&_sop=12&_dmd=1&_ipg=50&_fosrp=1";

            //    var httpclient = new HttpClient();
            //    var html = await httpclient.GetStringAsync(url);

            //    var htmlDocument = new HtmlDocument();
            //    htmlDocument.LoadHtml(html);

            //    var Product = htmlDocument.DocumentNode.Descendants("ul")
            //        .Where(node => node.GetAttributeValue("id","")
            //        .Equals("ListViewInner")).ToList();

            //    var productListItems = Product[0].Descendants("li")
            //        .Where(node => node.GetAttributeValue("id","")
            //        .Contains("item")).ToList();

            //    foreach(var product in productListItems)
            //    {
            //        Console.WriteLine(product.GetAttributeValue("listingId",""));
            //        Console.WriteLine(product.Descendants("h3")
            //            .Where(node => node.GetAttributeValue("class", "")
            //            .Equals("lvtitle")).FirstOrDefault().InnerText);
            //    }

            //        Console.WriteLine();
            //}
        }
    }
}
