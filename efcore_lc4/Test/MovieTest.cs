using efcore_lc4.Model;
using Xunit;

namespace efcore_lc4.Test
{
    public class MovieTest
    {

        [Fact]
        public void Movie_GetMovieName_ReturnsCoorectName()
        {
            var movieName = new Movie { MovieName = "Rapido y Furioso 1" };

            Assert.IsType<string>(movieName.MovieName);
            Assert.Equal("Rapido y Furioso 1", movieName.MovieName);
        }

        [Fact]
        public void Movie_MovieGenre_ReturnsCorrectGenre()
        {
            var movieGenre = new Movie { MovieGenre = "Action" };

            Assert.IsType<string>(movieGenre.MovieGenre);
            Assert.Equal("Action", movieGenre.MovieGenre);
        }

        [Fact]
        public void Movie_GetMovieDuration_ReturnsCorrectMovieDuration()
        {
            var movieDuration = new Movie { MovieDuration = 107 };

            Assert.IsType<int>(movieDuration.MovieDuration);
            Assert.Equal(107, movieDuration.MovieDuration);
        }

        [Fact]
        public void Movie_GetMovieBudget_returnsCorrectMovieBudget()
        {
            var movieBudget = new Movie { MovieBudget = 40000000 };

            Assert.IsType<float>(movieBudget.MovieBudget);
            Assert.Equal(40000000,00, movieBudget.MovieBudget);
        }

        [Fact]
        public void TestMovieWithInvalidProperties()
        {
            var movie = new Movie
            {
                MovieName  = null,
                MovieGenre = null,
                MovieDuration = 0,
                MovieBudget = 0
            };

            Assert.Null(movie.MovieName);
            Assert.Null(movie.MovieGenre);
            Assert.Equal(0, movie.MovieDuration);
            Assert.Equal(0, movie.MovieBudget);
        }
    }
}
