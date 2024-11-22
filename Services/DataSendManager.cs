using MangaStorageManager.Services;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MangaStorageManager
{
    internal class DataSendManager
    {
        string scriptMangaUrl     = "";
        string scriptZoneUrl      = "";
        string scriptRangementUrl = "";

        public DataSendManager() {
            this.scriptMangaUrl = ConfigURL.scriptMangaUrl;
            this.scriptZoneUrl = ConfigURL.scriptZoneUrl;
            this.scriptRangementUrl = ConfigURL.scriptRangementUrl;
        }

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

        /// <summary>
        /// Réceptionner les données selon les EAN
        /// </summary>
        /// <param name="eans"></param>
        /// <returns></returns>
        public async Task<string> getManga(string[] eans)
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
            return await ReceiveDataGet(queryParameters, this.scriptMangaUrl);
        }

        /// <summary>
        /// Réceptionner les données selon les titres
        /// </summary>
        /// <param name="titles"></param>
        /// <returns></returns>
        public async Task<string> getMangasByTitles(string[] titles)
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
            return await ReceiveDataGet(queryParameters, this.scriptMangaUrl);
        }

        /// <summary>
        /// Réceptionner les données selon les codes bars
        /// </summary>
        /// <param name="cbs"></param>
        /// <returns></returns>
        public async Task<string> getStorage(string[] cbs)
        {
            string cbstr = "[";
            foreach (string cb in cbs)
            {
                cbstr += cb + ",";
            }
            cbstr += "]";
            string[] queryParameters = new[]
            {
                "action=pull",
                "cb="+cbstr,
            };
            return await ReceiveDataGet(queryParameters, this.scriptZoneUrl);
        }

        /// <summary>
        /// Réceptionner les données selon les pièces
        /// </summary>
        /// <param name="pieces"></param>
        /// <returns></returns>
        public async Task<string> getStorageByPiece(string[] pieces)
        {
            string piecestr = "[";
            foreach (string piece in pieces)
            {
                piecestr += piece + ",";
            }
            piecestr += "]";
            string[] queryParameters = new[]
            {
                "action=pull",
                "piece="+piecestr,
            };
            return await ReceiveDataGet(queryParameters, this.scriptZoneUrl);
        }

        /// <summary>
        /// Réceptionner les données selon les EAN
        /// </summary>
        /// <param name="eans"></param>
        /// <returns></returns>
        public async Task<string> getManagementByEAN(string[] eans)
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
            return await ReceiveDataGet(queryParameters, this.scriptRangementUrl);
        }

        /// <summary>
        /// Réceptionner les données selon les codes bars.
        /// </summary>
        /// <param name="cbs"></param>
        /// <returns></returns>
        public async Task<string> getManagementByCB(string[] cbs)
        {
            string cbstr = "[";
            foreach (string cb in cbs)
            {
                cbstr += cb + ",";
            }
            cbstr += "]";
            string[] queryParameters = new[]
            {
                "action=pull",
                "cb="+cbstr,
            };
            return await ReceiveDataGet(queryParameters, this.scriptRangementUrl);
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

        /// <summary>
        /// Envoie de la requête get et récupération des données.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="urlBase"></param>
        /// <returns></returns>
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
