using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MobileMovieDB
{
    // Architecture Service Web - Orienté ressource
    //      * Classe RootObject (et classes imbriquées) corespondant à la ressource
    //      * Desérialisation des données JSON
    public class RootObject
    {
        [JsonProperty("results")]                   
        public List<Movie> Results { get; set; }    // Propriété utilisée dans l'application

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public class Movie
    {
        [JsonProperty("id")]                        
        public int Id { get; set; }                 // Utilisée

        [JsonProperty("title")]                    
        public string Title { get; set; }           // Utilisée

        [JsonProperty("popularity")]                
        public double Popularity { get; set; }      // Utilisée

        [JsonProperty("poster_path")]               
        public string PosterPath { get; set; }      // Utilisée

        [JsonProperty("overview")]                  
        public string Overview { get; set; }        // Utilisée

        [JsonProperty("release_date")]              
        public string ReleaseDate { get; set; }     // Utilisée

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("genre_ids")]
        public List<int> GenreIds { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("adult")]
        public bool Adult { get; set; }
    }
}
