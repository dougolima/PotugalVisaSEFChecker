using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace PortugalVistoChecker
{
    class Program
    {
        private const string URL = "https://pedidodevistos.mne.pt/VistosOnline/VerificarEstado";
        private const string URLWithParameters = "https://pedidodevistos.mne.pt/VistosOnline/VerificarEstado?user=FS421311&password=i6oys1eif2&accao=estado&lang=PT";
        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(URLWithParameters,"POST");
            Console.WriteLine(doc.DocumentNode.ChildNodes[3].ChildNodes[3].ChildNodes[3].ChildNodes[13].ChildNodes[0].InnerHtml);
            Console.ReadKey();
        }


    }
}
