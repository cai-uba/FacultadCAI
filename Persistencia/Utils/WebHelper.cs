﻿using System.Text;

namespace Persistencia.Utils
{
    internal static class WebHelper
    {
        static HttpClient client = new HttpClient();
        static string rutaBase = "https://cai-tp.azurewebsites.net/api/";

        public static HttpResponseMessage Get(string url)
        {
            var uri = rutaBase + url;

            HttpResponseMessage response = client.GetAsync(uri).Result;  // Blocking call!

            return response;
        }

        public static HttpResponseMessage Post(string url, string jsonRequest)
        {
            var uri = rutaBase + url;

            var data = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PostAsync(uri, data).Result;

            return response;

        }

        public static HttpResponseMessage Put(string url, string jsonRequest)
        {
            var uri = rutaBase + url;

            var data = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PutAsync(uri, data).Result;

            return response;

        }

        public static HttpResponseMessage Patch(string url, string jsonRequest)
        {
            var uri = rutaBase + url;

            var data = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PatchAsync(uri, data).Result;

            return response;

        }

        public static HttpResponseMessage DeleteConBody(string url, string jsonRequest)
        {
            var uri = rutaBase + url;

            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri(uri),
                Content = new StringContent(jsonRequest, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = client.SendAsync(request).Result;

            return response;
        }
    }
}