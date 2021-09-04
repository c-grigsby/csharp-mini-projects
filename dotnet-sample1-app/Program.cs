using System;
using System.Collections.Generic;

namespace TV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Show one = new Show(){
                Name = "Parks and Recreation",
                NumEpisodes = 125, 
                Year = 2009, 
                Actors = new List<string>{
                   "Amy Poehler", "Aziz Ansari", "Nick Offerman" 
                }
            };
            Show two = new Show(){
                Name = "Burn Notice",
                NumEpisodes = 111, 
                Year = 2007, 
                Actors = new List<string>{
                   "Jeffery Donovan", "Gabriel Anwar", "Bruce Cambell" 
                }
            };
            Show three = new Show(){
                Name = "The X-Files",
                NumEpisodes = 217, 
                Year = 1993, 
                Actors = new List<string>{
                   "David Duchovny", "Gillian Anderson", "Mitch Pileggi" 
                }
            };

            List<Show> shows = new List<Show>(){
                one, two, three
            };
            Console.WriteLine("-----Before Aplha Sort Sort------");
            foreach(Show s in shows){
                Console.WriteLine(s);
            }

            shows.Sort();
            Console.WriteLine("-----After Aplha Sort------");
            ;
            foreach(Show s in shows){
                Console.WriteLine(s);
            }

            shows.Sort(new NumEpisodeComparer());
            Console.WriteLine("-----After Num of Episode Sort------");
             foreach(Show s in shows){
                Console.WriteLine(s);
            }
        }
    }
    public class NumEpisodeComparer: IComparer<Show>{
        public int Compare(Show x, Show y){
            return x.NumEpisodes - y.NumEpisodes;
        }
    }
}
