using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaStorageManager.Services.ResponsesType
{
    internal class ResponseManagement
    {
        public string Status { get; set; }
        public List<List<object>> Data { get; set; }
    }
}
