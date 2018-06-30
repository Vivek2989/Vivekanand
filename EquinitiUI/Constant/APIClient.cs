using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;

namespace EquinitiUI.Constant
{
    public class APIClient
    {
        private string Base_URL = System.Configuration.ConfigurationManager.AppSettings["EquinityWebApi"].ToString();

        public HttpClient GetResponse()
        {
            try
            {
                HttpClient Client = new HttpClient();
                Client.BaseAddress = new Uri(Base_URL);
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                return Client;
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }
    }
}