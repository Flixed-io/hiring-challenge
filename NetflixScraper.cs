using System;
using System.Collections;
using System.Text.Json;

namespace scraping
{
    public class MovieData {
        public string id { get; set; }
        public string jsonData { get; set; }

        public MovieData(string id, string jsonData)
        {
            id = id;
            jsonData = jsonData;
        }
    }

    public class NetflixScraper
    {
        JSONStore jsonStore;

        public NetflixScraper()
        {
            jsonStore = new JSONStore();
        }

        public scrapeAllContent()
        {
            IList<MovieData> movies = scrapeMovieList();
            foreach (MovieData movie in movies)
            {
                // storeMovie(movie);
                int id = movie.id;
                string jsonMovie = JsonSerializer.Serialize(movie.jsonData);
                if (jsonStore.get(id) == "")
                {
                    jsonStore.insert(jsonMovie, id);
                }
                else
                {
                    jsonStore.update(jsonMovie, id);
                }
            }
        }

        private IList<MovieData> scrapeMovieList()
        {
            IList<MovieData> movies = new MovieData[] { };

            // This section would contain code to scrape data from Netflix.
            // Here's some pseudo code of what it may look like:
            //
            // moviePageUrls = ...
            // for (int i = 0; i < moviePageUrls.length; i++) {
            //      HTMLData data = chromedriver.fetch(moviePageUrls[i])
            //      string id = data.title + data.year
            //      string jsonData = constructed JSON string
            //      movies.Add(new MovieData(id, jsonData));
            // }

            return movies;
        }
    }
}
