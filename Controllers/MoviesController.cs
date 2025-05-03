using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul10_103022300020.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public static List<Movie> movieList = new List<Movie>
    {
        new Movie ("The Shawshank Redemption", "Frank Darabont", new List<String>{"Tim Robbins", "Morgan Freeman","Bob gunton"},"A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."),
        new Movie ("The Godfather", "Francis Ford Coppola", new List<string>{"Marlon Brandon", "Al Pacino", "James caan"}, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."),
        new Movie ("The Dark Knight", "Christopher Nolan", new List<String>{"Christian Bale", "Heath Ledger","Aaron Eckhart"}, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.")
    };
      // GET: api/<MoviesController>
      [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return movieList;
        }

        // GET api/<MoviesController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return movieList[id];
        }

        // POST api/<MoviesController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            movieList.Add(value);
        }


        // DELETE api/<MoviesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            movieList.RemoveAt(id);
        }
    }
}
