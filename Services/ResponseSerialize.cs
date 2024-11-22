using MangaStorageManager.Services.ResponsesType;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangaStorageManager.Services
{
    internal class ResponseSerialize
    {
        public static List<List<string>> GetMangaResponseData(string json)
        {
            List<List<string>> finalData = new List<List<string>>();
            ResponseManga rm = JsonConvert.DeserializeObject<ResponseManga>(json);
            foreach (var item in rm.Data)
            {
                try
                {
                    List<string> line = new List<string>();
                    line.Add(item[0].ToString());
                    line.Add(item[1].ToString());
                    line.Add(item[2].ToString());
                    line.Add(item[3].ToString());
                    finalData.Add(line);
                }
                catch
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine(string.Join(", ", item));
                }
            }
            return finalData;
        }

        public static List<List<string>> GetManagementResponseData(string json)
        {
            List<List<string>> finalData = new List<List<string>>();
            ResponseManagement rm = JsonConvert.DeserializeObject<ResponseManagement>(json);
            foreach (var item in rm.Data)
            {
                try
                {
                    List<string> line = new List<string>();
                    line.Add(item[0].ToString());
                    line.Add(item[1].ToString());
                    line.Add(item[2].ToString());
                    line.Add(item[3].ToString());
                    finalData.Add(line);
                } catch {
                    Console.WriteLine("ERROR");
                    Console.WriteLine(string.Join(", ", item));
                }
            }
            return finalData;
        }

        public static List<List<string>> GetStorageResponseData(string json)
        {
            List<List<string>> finalData = new List<List<string>>();
            ResponseStorage rm = JsonConvert.DeserializeObject<ResponseStorage>(json);
            foreach (var item in rm.Data)
            {
                try
                {
                    List<string> line = new List<string>();
                    line.Add(item[0].ToString());
                    line.Add(item[1].ToString());
                    line.Add(item[2].ToString());
                    finalData.Add(line);
                }
                catch
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine(item.Count);
                    Console.WriteLine(string.Join(", ", item));
                }
            }
            return finalData;
        }
    }
}
