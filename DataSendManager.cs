using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MangaStorageManager
{
    internal class DataSendManager
    {
        string scriptUrl = "https://script.google.com/macros/s/AKfycbwJH64QfLAzkmEaeWCp9iAmzB7tZm_d9SpxFmP2JqGuNpv4Ffm0cBspIvzzGm_FIx6l/exec";
        // https://script.google.com/macros/s/AKfycbwJH64QfLAzkmEaeWCp9iAmzB7tZm_d9SpxFmP2JqGuNpv4Ffm0cBspIvzzGm_FIx6l/exec

        public async void sendData(string titre, string num, string editeur, string EAN)
        {
            var values = new
            {
                values = new[] { 
                    EAN,
                    titre, 
                    num, 
                    editeur, 
                }
            };

            string json = System.Text.Json.JsonSerializer.Serialize(values);
            Console.WriteLine(json);
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(this.scriptUrl, content);
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
    }
}
