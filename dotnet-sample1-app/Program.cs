using System;
using System.Collections.Generic;
using Courses;

namespace TV
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Show one = new Show()
            // {
            //     Name = "Parks and Recreation",
            //     NumEpisodes = 125,
            //     Year = 2009,
            //     Actors = new List<string>{
            //        "Amy Poehler", "Aziz Ansari", "Nick Offerman"
            //     }
            // };
            // Show two = new Show()
            // {
            //     Name = "Burn Notice",
            //     NumEpisodes = 111,
            //     Year = 2007,
            //     Actors = new List<string>{
            //        "Jeffery Donovan", "Gabriel Anwar", "Bruce Cambell"
            //     }
            // };
            // Show three = new Show()
            // {
            //     Name = "The X-Files",
            //     NumEpisodes = 217,
            //     Year = 1993,
            //     Actors = new List<string>{
            //        "David Duchovny", "Gillian Anderson", "Mitch Pileggi"
            //     }
            // };

            // List<Show> shows = new List<Show>(){
            //     one, two, three
            // };
            // Console.WriteLine("-----Before Aplha Sort Sort------");
            // foreach (Show s in shows)
            // {
            //     Console.WriteLine(s);
            // }

            // shows.Sort();
            // Console.WriteLine("-----After Aplha Sort------");
            // ;
            // foreach (Show s in shows)
            // {
            //     Console.WriteLine(s);
            // }

            // shows.Sort(new NumEpisodeComparer());
            // Console.WriteLine("-----After Num of Episode Sort------");
            // foreach (Show s in shows)
            // {
            //     Console.WriteLine(s);
            // }

            Console.WriteLine("\n-----Create a List<T> of 6 Course objects------\n");
            List<Course> courses = new List<Course>(); 
            Course course1 = new Course() {
                Name = "CSCI-330",
                Title = "System Analysis and Software Engineering I", 
                Credits = 3.0, 
                Description = "Topics include requirements engineering, unit testing, etc."
            };
            courses.Add(course1);

            Course course2 = new Course() {
                Name = "CSCI-220",
                Title = "Data Structures", 
                Credits = 3.0, 
                Description = "Asymptotic efficiency, alogorithm analysis, etc."
            };
            courses.Add(course2);

            Course course3 = new Course() {
                Name = "CSCI-150",
                Title = "Intro to Algorithmic Design II", 
                Credits = 4.0, 
                Description = "Object oriented design, etc."
            };
            courses.Add(course3);

            Course course4 = new Course() {
                Name = "CSCI-140",
                Title = "Intro to Algorithmic Design I", 
                Credits = 4.0, 
                Description = "Algo fundamentals loops, conditional statements, etc."
            };
            courses.Add(course4);

            Course course5 = new Course() {
                Name = "Math 344",
                Title = "Linear Algebra", 
                Credits = 3.5, 
                Description = "Vector spaces, matrices, transformations, etc "
            };
            courses.Add(course5);

            Course course6 = new Course() {
                Name = "ENGL-231 ",
                Title = "Film, New Media, and Culture", 
                Credits = 3.0, 
                Description = "A course that will have little to do with your major"
            };
            courses.Add(course6);

            System.Console.WriteLine("------- (List Not Sorted) ----\n");
            foreach(Course c in courses){
                System.Console.WriteLine(c);
            }

            System.Console.WriteLine("------- (List Sorted by Default: Name) ----\n");
            courses.Sort();

            foreach(Course c in courses){
                System.Console.WriteLine(c);
            }

             System.Console.WriteLine("------- (List Sorted by Credits: Comparer Obj) ----\n");
             courses.Sort(new CourseCreditComparer());

             foreach(Course c in courses){
                 System.Console.WriteLine(c);
             }

            
         }
    }

    public class NumEpisodeComparer : IComparer<Show>
    {
        public int Compare(Show x, Show y)
        {
            return x.NumEpisodes - y.NumEpisodes;
        }
    }
}
