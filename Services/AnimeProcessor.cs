using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AmmiServices.Services
{
    public class AnimeProcessor
    {
        public static async Task/*<Anime>*/ LoadAnime( int animeNumber = 0)
        {
            string url = "";

            if (animeNumber > 0)
            {
                url = "";
            }
            else
            {
                url = "";
            }

            using (HttpResponseMessage response = await Apihelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    //Anime anime = await response.Content.ReadAsStringAsync();
                    //return anime;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
