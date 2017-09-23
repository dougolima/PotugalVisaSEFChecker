using HtmlAgilityPack;
using PortugalVisaSEFCheckerTraySystem.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PortugalVisaSEFCheckerTraySystem
{
    public class HttpChecker
    {
        private const string URL = "https://pedidodevistos.mne.pt/VistosOnline/VerificarEstado";
        private const string URLWithParameters = "https://pedidodevistos.mne.pt/VistosOnline/VerificarEstado?user=#USR#&password=#PWD#&accao=estado&lang=PT";
        private static readonly HttpClient client = new HttpClient();
        
        public static string Do()
        {
            try
            {
                HtmlAgilityPack.HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load(URLWithParameters.Replace("#USR#", Settings.Default.user).Replace("#PWD#", Settings.Default.password), "POST");
                return doc.DocumentNode.ChildNodes[3].ChildNodes[3].ChildNodes[3].ChildNodes[13].ChildNodes[0].InnerHtml;
            }
            catch(Exception ex)
            {
                //return ex.Message;
                return "erro";
            }
        }
    }
}
