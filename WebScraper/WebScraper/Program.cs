using System;
using System.Net.Http;

namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://www.ebay.com/sch/i.html?_from=R40&_nkw=surface+book+2&_in_kw=1&_ex_kw=&_sacat=0&LH_Complete=1&_udlo=&_udhi=&_samilow=&_samihi=&_sadis=15&_stpos=98106&_sargn=-1%26saslc%3D1&_salic=1&_sop=12&_dmd=1&_ipg=50&_fosrp=1";
            HttpClient httpclient = new HttpClient();
            var html = httpclient.GetStringAsync(url);
            Console.WriteLine(html.Result);
            Console.ReadLine();
        }
    }
}
