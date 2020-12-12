using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterGoodson
{
    class Blockbuster
    {
        
        public static List<Movie> CreateList()
        {
            List<Movie> Movies = new List<Movie>();

            DVD BourneIdentity = new DVD();
            BourneIdentity.Title = "Bourne Identity";
            BourneIdentity.Category = Genre.Action;
            BourneIdentity.RunTime = 119;
            BourneIdentity.Scenes = new List<string>
            {
                {"he's being chased" },
                {"he's still being chased" },
                {"there's a girl" }
            };

            DVD MissionImpossible = new DVD();
            MissionImpossible.Title = "Mission Impossible";
            MissionImpossible.Category = Genre.Action;
            MissionImpossible.RunTime = 110;
            MissionImpossible.Scenes = new List<string>
            {
                {"there's a chase scene" },
                {"shoot out" },
                {"saves the girl" }
            };

            DVD JamesBond = new DVD();
            JamesBond.Title = "James Bond: Casino Royale";
            JamesBond.Category = Genre.Action;
            JamesBond.RunTime = 145;
            JamesBond.Scenes = new List<string>
            {
                {"people are running fast" },
                {"he goes undercover" },
                {"the girl is rescued" }
            };


            VHS StickIt = new VHS();
            StickIt.Title = "Stick It";
            StickIt.Category = Genre.Drama;
            StickIt.RunTime = 103;
            StickIt.Scenes = new List<string>
            {
                {"she chokes at worlds" },
                {"biking with friends" },
                {"joins VGA" },
            };


            VHS MissSloane = new VHS();
            MissSloane.Title = "Miss Sloane";
            MissSloane.Category = Genre.Drama;
            MissSloane.RunTime = 132;
            MissSloane.Scenes = new List<string>
            {
                {"they're going over a case"},
                {"she changes teams" },
                {"her client wins" }
            };

            VHS AceVentura = new VHS();
            AceVentura.Title = "Ace Ventura";
            AceVentura.Category = Genre.Comedy;
            AceVentura.RunTime = 87;
            AceVentura.Scenes = new List<string>
            {
                {"there's something with animals" },
                {"Jim Carreyy does something crazy" },
                {"He embarasses himself" }
            };

            Movies.Add(BourneIdentity);
            Movies.Add(MissionImpossible);
            Movies.Add(JamesBond);
            Movies.Add(StickIt);
            Movies.Add(MissSloane);
            Movies.Add(AceVentura);

            return Movies;
        }
       
        public static void PrintMovies(List<Movie> movies)
        {
            int index = 0; 

            foreach(Movie movie in movies)
            {
                Console.WriteLine($"{index}: {movie.Title}");
                index += 1;
            }
        }

        public static Movie CheckOut()
        {

            List<Movie> movieList = CreateList();
            Movie userMovie;

            do
            {
                Console.WriteLine("Which Movie would you like to watch? Please choose a number from the list below: ");
                PrintMovies(movieList);
                string userChoice = Console.ReadLine();
                Console.WriteLine();
                bool isInt = int.TryParse(userChoice, out int movieNum);

                if(isInt && movieNum>=0 && movieNum < movieList.Count)
                {
                    movieList[movieNum].PrintInfo();
                    userMovie = movieList[movieNum];
                    Console.WriteLine();
                    

                    do
                    {
                        Console.WriteLine("Do you want to watch the movie (y/n)?");
                        Console.WriteLine();
                        string userWatch = Console.ReadLine();

                        if (userWatch.Equals("Y", StringComparison.OrdinalIgnoreCase))
                        {
                            userMovie.Play();

                            Console.WriteLine();

                        }
                        else if (userWatch.Equals("N", StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("ADIOS!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please choose y or n");
                        }

                    } while (KeepWatch());

                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number from the list");
                }

            } while (true);

            return userMovie;
        }

    public static bool KeepWatch()
        {

            do
            {
                Console.WriteLine("Would you like to keep watching?");
                string keepWatch = Console.ReadLine();
                Console.WriteLine();

                if (keepWatch.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else if (keepWatch.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("ADIOS!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please choose y or n");

                }

            } while (true);
        }
    }
}
