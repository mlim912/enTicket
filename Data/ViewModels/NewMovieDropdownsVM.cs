using enTicket.Models;

namespace enTicket.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM()
        {
        }

        public NewMovieDropdownsVM(List<Producer>? producers, List<Cinema> cinemas, List<Actor> actors)
        {
            Producers = producers;
            Cinemas = cinemas;
            Actors = actors;
        }

        public List<Producer>? Producers { get; set; }
        public List<Cinema>? Cinemas { get; set; }
        public List <Actor>? Actors { get; set; }
    }
}
