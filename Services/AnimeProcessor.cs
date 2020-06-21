using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AmmiServices.Services
{
    public class AnimeProcessor
    {
        public async Task<Anime> LoadAnime( int animeNumber = 0)
        {
            string url = "";

            if (animeNumber > 0)
            {
                url = "https://api.jikan.moe/v3/anime/1/episodes/2";
            }
            else
            {
                url = "https://api.jikan.moe/v3/anime/1/episodes/2";
            }

            using (HttpResponseMessage response = await Apihelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Anime anime = await response.Content.ReadAsAsync<Anime>();
                    return anime; 
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
