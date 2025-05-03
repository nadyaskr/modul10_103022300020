namespace modul10_103022300020.Controllers
{
    public class Movie
    {
        public String title { get; set; }
        public String Director { get; set; }
        public List<String> Stars { get; set; }
        public String Description { get; set; }

        public Movie(String title, String director, List<String> Stars, String description)
        {
            this.title = title;
            this.Director = director;
            this.Stars = Stars;
            this.Description = description;
        }

    }

}


