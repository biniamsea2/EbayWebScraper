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
            //loop through the titles of the search
            //foreach (var item in doc.DocumentNode.SelectNodes("//a[@class='vip']"))
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            ////loop through the price of the search
            //foreach (var item in doc.DocumentNode.SelectNodes("//span[@class='bold bidsold']"))
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            ////loop through the buying options
            //foreach (var item in doc.DocumentNode.SelectNodes("//li[@class ='lvformat']"))
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            foreach (var item in doc.DocumentNode.SelectNodes("//img[@class ='img']"))
            {
                Console.WriteLine(item.InnerText);
            }
        }
    }
}
