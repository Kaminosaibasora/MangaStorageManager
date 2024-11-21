using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MangaStorageManager
{
    internal class DataSendManager
    {
        //string scriptMangaUrl = "https://script.google.com/macros/s/AKfycbyOHtUSS0WLcrazNfEpbyo-oOH5mjy7eitWoSp0BK0VGzo-Z6TEqGvcL_gm7STr37bk/exec";
        string scriptMangaUrl = "https://script.google.com/macros/s/AKfycbyYmGx7rHsQAw831sOtKacaAIiVZpRipriaE4DARhUX1NEfsuSiQ00URNBAe7U6jXoJ/exec";
        string scriptZoneUrl = "https://script.google.com/macros/s/AKfycbwk4Op9MhCCOLvZc9E12FIR64ZlKC88rPIUrpKtGOaYmCrSriRLhHrFYxTmKFjRM8-9Mw/exec";
        string scriptRangementUrl = "https://script.google.com/macros/s/AKfycbz-_2ooL8vLV0_3vwTZj91XWt8vdrm5m2eclv6OtTrpNp0SfF5zu8_zFn_hxWKbRC8FVw/exec";

        /// <summary>
        /// Prépare les données et la requête pour l'envoie d'un manga vers la BDD.
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="num"></param>
        /// <param name="editeur"></param>
        /// <param name="ean"></param>
        public void SendManga(string titre, string num, string editeur, string ean)
        {
            string[] queryParameters = new[]
            {
                "EAN="+ean,
                "titre="+titre,
                "num="+num,
                "editeur="+editeur,
                "action=push",
            };
            SendDataGet(queryParameters, this.scriptMangaUrl);
        }

        /// <summary>
        /// Prépare les données et la requête pour l'envoie d'un storage vers la BDD.
        /// </summary>
        /// <param name="piece"></param>
        /// <param name="description"></param>
        /// <param name="cb"></param>
        public void SendStorage(string piece, string description, string cb)
        {
            string[] queryParameters = new[]
            {
                "piece="+piece,
                "desc="+description,
                "CB="+cb,
                "action=push",
            };
            SendDataGet(queryParameters, this.scriptZoneUrl);
        }

        /// <summary>
        /// Prépare les données et la requête pour l'envoie d'un management vers la BDD.
        /// </summary>
        /// <param name="ean"></param>
        /// <param name="cb"></param>
        /// <param name="status"></param>
        public void SendManagement(string ean, string cb, string status)
        {
            string[] queryParameters = new[]
            {
                "EAN="+ean,
                "CB="+cb,
                "status="+status,
                "action=push",
            };
            SendDataGet(queryParameters, this.scriptRangementUrl);
        }

        public string getManga(string[] eans)
        {
            string eanstr = "[";
            foreach (string ean in eans)
            {
                eanstr += ean + ",";
            }
            eanstr += "]";
            string[] queryParameters = new[]
            {
                "action=pull",
                "EAN="+eanstr,
            };
            string data = "OK";
            ReceiveDataGet(queryParameters, this.scriptMangaUrl);
            return data;

        }

        public string getMangasByTitles(string[] titles)
        {
            string titlestr = "[";
            foreach (string title in titles)
            {
                titlestr += title + ",";
            }
            titlestr += "]";
            string[] queryParameters = new[]
            {
                "action=pull",
                "title="+titlestr,
            };
            string data = "OK";
            ReceiveDataGet(queryParameters, this.scriptMangaUrl);
            return data;

        }

        // **********************************************************************************************
        // **********************************************************************************************
        // **********************************************************************************************

        /// <summary>
        /// Envoie les données via une requête POST (à revoir)
        /// </summary>
        /// <param name="json"></param>
        /// <param name="url"></param>
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

        /// <summary>
        /// Envoie les données via une requête GET.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="urlBase"></param>
        public async void SendDataGet(string[] parameters, string urlBase)
        {
            string url = $"{urlBase}?{string.Join("&", parameters)}";
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

        public async Task<string> ReceiveDataGet(string[] parameters, string urlBase)
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
                    return responseBody;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Erreur lors de la requête : {e.Message}");
                }
                return "ERROR";
            }
        }
    }
}
