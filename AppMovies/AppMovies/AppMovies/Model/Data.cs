using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks; // Pour des appels asynchrones des ressources using Newtonsoft.Json; using System.Net; 
using System.IO;

namespace AppMovies.Model
{
    class Data
    {
        private const string key = "0f1d0b73d25595e9806aede52220a269";
        private const string urlSearch = "https://api.themoviedb.org/3/search/movie?api_key={0}&query={1}&language=fr-FR";
        private const string urlDetails = "https://api.themoviedb.org/3/movie/{0}?api_key={1}&language=fr-FR";

        private WebClient client;

        public Data()
        {
            this.client = new WebClient();
        }

        // Recherche TOUS les films dont le TITRE COMMENCE avec les caractères saisis par l'utilisateur 
        //     * Retourne un objet ressource RootObject 
        //     * Cette méthode permet de LISTER les films correspondants 
        //     * L'utilisateur pourra ensuite choisir un film pour voir le détail (cf. GetMovie()) 
        public async Task<RootObject> FindMoviesByTitle(string search)
        {
            try
            {
                this.client.OpenReadAsync(
                    new Uri(String.Format(
                        urlSearch,
                        key,
                        "reg"
                        )
                    )
                );
                this.
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new RootObject();
            }
        }

        // Recherche du film dont le titre correspond strictement à la saisie utilisateur 
        //     * Cette méthode est appelée lorsque l'utilisateur CHOISI UN FILM dans la LISTE 
        //     * Retourne un objet ressource RootObject 
        public async Task<RootObject> GetMovie(string title)
        {

        }


    }
}
