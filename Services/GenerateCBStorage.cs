using System;

namespace MangaStorageManager.Services
{
    internal class GenerateCBStorage
    {
        /// <summary>
        /// Génère un identifiant unique grâce à GUID.
        /// </summary>
        /// <param name="taille"></param>
        /// <returns></returns>
        public string getGenerateCB(int taille = 8)
        {
            //return  $"{DateTime.Now:yyyyMMddHHmmss}{Guid.NewGuid().ToString().Substring(0, taille)}";
            return $"{Guid.NewGuid().ToString().Substring(0, taille)}";
        }
    }
}
