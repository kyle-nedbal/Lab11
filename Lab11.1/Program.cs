using System;
using System.Collections.Generic;

namespace Lab11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWantsToContinue;
            string userCategory;

            var movieList = new List<Movie>
            {
                new Movie("Toy Story", "animated"),
                new Movie("A Bug's Life", "animated"),
                new Movie("The Incredibles", "animated"),
                new Movie("Star Wars: The Last Jedi", "scifi"),
                new Movie("Avengers: Infinity War", "scifi"),
                new Movie("1917", "drama"),
                new Movie("The Irishman", "drama"),
                new Movie("The Grudge", "horror"),
                new Movie("It", "horror")
            };

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine(" ");
            Console.WriteLine("There are 10 movies in this list");
            do
            {
                Console.WriteLine("What category are you interested in? (animated, drama, horror, or scifi)");
                userCategory = Console.ReadLine().ToLower();

                Console.WriteLine("");

                if (userCategory != "animated" && userCategory != "scifi" && userCategory != "horror" && userCategory != "drama")
                {
                    Console.WriteLine("Invalid Entry! (Please input animated, drama, horror, or scifi");
                    userCategory = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                }

                Console.WriteLine($"Below are the movies included in the {userCategory} category:");

                foreach (var movie in movieList)
                {
                    if (movie.GetCategory() == userCategory)
                    {
                        Console.WriteLine(movie.GetTitle());
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("Would you like to continue? (y/n)");
                userWantsToContinue = Console.ReadLine().ToLower();
                Console.WriteLine("");

                if (userWantsToContinue != "y" && userWantsToContinue != "n")
                {
                    Console.WriteLine("Invalid Entry! (Please input y or n)");
                    userWantsToContinue = Console.ReadLine().ToLower();
                    Console.WriteLine("");
                }
            } while (userWantsToContinue == "y");
        }
    }
}
