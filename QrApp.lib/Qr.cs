using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        /*  Инфо для изучения
         *  https://www.nuget.org/packages/RestSharp
            http://restsharp.org/getting-started/#basic-usage
        */

using RestSharp;
using QrApp.lib;

namespace QrApp.lib
{
    public class Qr
    {
        string website { get; set; }

        public static void genQR(string text, int size)
        {
            string query = string.Format("code/?{0}&{1}&0", text, size);

            var client = new RestClient("https://qrcoder.ru");
            var request = new RestRequest($"code/?{text}&{size}&0");

            var response = client.Execute(request);
            var result = response.Content;
        }
    }
}
