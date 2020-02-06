using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestSharp;
using QrApp.lib;

namespace QrApp.lib
{
    public class Qr
    {
        public static void genQR(string text, int size)
        {

            var client = new RestClient("https://qrcoder.ru");
            var request = new RestRequest($"code/?{text}&{size}&0");

            var response = client.Execute(request);
            var result = response.Content;  
        }
    }
}
