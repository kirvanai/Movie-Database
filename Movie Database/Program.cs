namespace Movie_Database
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("Halloween", "horror"));
            movies.Add(new Movie("Eyes Wide Shut", "drama"));
            movies.Add(new Movie("Bladerunner", "scifi"));
            movies.Add(new Movie("Spirited Away", "animated"));
            movies.Add(new Movie("Hereditary", "horror"));
            movies.Add(new Movie("There Will Be Blood", "drama"));
            movies.Add(new Movie("Interstellar", "scifi"));
            movies.Add(new Movie("Akira", "animated"));
            movies.Add(new Movie("The Wailing", "horror"));
            movies.Add(new Movie("The Godfather", "drama"));
            movies.Add(new Movie("Ex Machina", "scifi"));
            movies.Add(new Movie("Song Of The Sea", "animated"));
            movies.Add(new Movie("The Exorcist", "horror"));
            movies.Add(new Movie("A Most Violent Year", "drama"));
            movies.Add(new Movie("2001 Space Odyssey", "scifi"));
            movies.Add(new Movie("Lilo And Stitch", "animated"));

            Console.WriteLine("Welcome to the Movie List Application");
            Console.WriteLine($"There are {movies.Count} movies in this list.");
            MovieLister(movies);
            string yOrN = Validator.YesOrNoValidator(Console.ReadLine());
            while (yOrN == "y")
            {
                MovieLister(movies);
                yOrN = Validator.YesOrNoValidator(Console.ReadLine());
            }
            if (yOrN == "n")
            {
                Console.WriteLine("Goodbye! Thanks for using Movie List!");
            }

        }

        public static void MovieLister(List<Movie> movies)
        {
            string[] genres = { "animated", "drama", "horror", "scifi" };
            Console.WriteLine("Which category are you interested in? Select number:");
            for (int i = 0; i < genres.Length; i++)
            {
                Console.WriteLine($"{i+1}) {genres[i]}");
            }
            int userInput = Validator.CategoryValidator(Console.ReadLine());
            string genreSelect = genres[userInput-1];
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Category == genreSelect)
                {
                    Console.WriteLine(movies[i].Title);
                }
            }
            Console.WriteLine("Continue? (y/n)");
        }
    }
}