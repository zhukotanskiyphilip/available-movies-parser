using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Available_movies_parser
{
    public class GetRequest
    {
        HttpWebRequest httpWebRequest;

        string address;
        public string response { get; set; }

        public GetRequest(string address)
        {
            this.address = address;
        }

        public void Run()
        {
            httpWebRequest = (HttpWebRequest)WebRequest.Create(address);
            httpWebRequest.Method = "GET";

            try
            {
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream stream = httpWebResponse.GetResponseStream();
                if (stream != null) response = new StreamReader(stream).ReadToEnd();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
