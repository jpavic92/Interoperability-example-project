using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using ShazamClient.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShazamClient.Services
{
    public static class ShazamRestService
    {
        private const string GET_SONGS_ARTISTS = "https://shazam.p.rapidapi.com/search?term=";
        private const string GET_AUTOCOMPLETE_HINTS = "https://shazam.p.rapidapi.com/auto-complete?term=";
        private const string GET_PLAYLIST = "https://shazam.p.rapidapi.com/songs/list-artist-top-tracks?id=";
        private const string RAPIDAPI_KEY = "6c05ba12ecmsh9fc387a3e8330cfp1a2bcdjsn0ecc33cdd44d";
        private const string RAPIDAPI_URL = "shazam.p.rapidapi.com";
        private const string URL_ENCODE_SPACE = "%20";

        public static ICollection<Hit> GetTracks(string searchText)
        {
            string search = searchText.Trim().Replace(" ", URL_ENCODE_SPACE);
            var client = new RestClient(GET_SONGS_ARTISTS + search);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", RAPIDAPI_KEY);
            request.AddHeader("x-rapidapi-host", RAPIDAPI_URL);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Root root = JsonConvert.DeserializeObject<Root>(response.Content);
                return root.Tracks.Hits;
            }
            return null;
        }

        public static ICollection<Hit> GetArtists(string searchText)
        {
            string search = searchText.Trim().Replace(" ", URL_ENCODE_SPACE);
            var client = new RestClient(GET_SONGS_ARTISTS + search);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", RAPIDAPI_KEY);
            request.AddHeader("x-rapidapi-host", RAPIDAPI_URL);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Root root = JsonConvert.DeserializeObject<Root>(response.Content);
                return root.Artists.Hits;
            }
            return null;
        }

        public static HintResults GetHints(string typedText)
        {
            string text = typedText.Trim();
            var client = new RestClient(GET_AUTOCOMPLETE_HINTS + text);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", RAPIDAPI_KEY);
            request.AddHeader("x-rapidapi-host", RAPIDAPI_URL);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                HintResults hints = JsonConvert.DeserializeObject<HintResults>(response.Content);
                return hints;
            }

            return null;
        }

        public static PlaylistResult GetPlaylist (string artistId)
        {
            var client = new RestClient(GET_PLAYLIST + artistId);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", RAPIDAPI_KEY);
            request.AddHeader("x-rapidapi-host", RAPIDAPI_URL);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                PlaylistResult root = JsonConvert.DeserializeObject<PlaylistResult>(response.Content);
                return root;
            }
            return null;
        }
    }
}
