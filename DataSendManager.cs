using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MangaStorageManager
{
    internal class DataSendManager
    {
        string scriptMangaUrl = "https://script.google.com/macros/s/AKfycbyOHtUSS0WLcrazNfEpbyo-oOH5mjy7eitWoSp0BK0VGzo-Z6TEqGvcL_gm7STr37bk/exec";

        public void SendManga(string titre, string num, string editeur, string EAN)
        {
            string[] queryParameters = new[]
            {
                "EAN="+EAN,
                "titre="+titre,
                "num="+num,
                "editeur="+editeur,
            };
            SendDataGet(queryParameters, this.scriptMangaUrl);
        }

        public void SendStorage(string piece, string description, string cb)
        {
            Console.WriteLine("Storage");
        }

        public void SendManagement(string ean, string cb)
        {
            Console.WriteLine("Management");
        }

        // **********************************************************************************************
        // **********************************************************************************************
        // **********************************************************************************************

        public async void SendDataPost(string json, string url)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Réponse du serveur : " + result);
                }
                else
                {
                    Console.WriteLine("Erreur : " + response.StatusCode);
                }
            }
        }

        public async void SendDataGet(string[] parameters, string urlBase)
        {
            string url = $"{urlBase}?{string.Join("&", parameters)}";
            Console.WriteLine(url);
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Erreur lors de la requête : {e.Message}");
                }
            }
        }
    }
}
