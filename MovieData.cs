namespace scraping
{
    public class MovieData
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public number year { get; set; }

        public MovieData(string id, string title, string description, number year)
        {
            id = id;
            title = title;
            description = description;
            year = year;
        }
    }
}
