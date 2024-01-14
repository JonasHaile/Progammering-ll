using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{

    // This viewmodel will contain these attributes: 
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        // A SelectList containing the list of genres. This allows the user to select a grenre from the list
        public SelectList Genres { get; set; }
        // MovieGenre which contans the selected genre. 
        public string? MovieGenre { get; set; }

        // SearchString which contains the test the users enter in the search text box. 
        public string? SearchString { get; set; }
    }
}
