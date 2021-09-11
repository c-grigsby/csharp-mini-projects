using System;

namespace Courses
{
    public class Course: IComparable<Course>, ICreditable<Course>
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public double Credits { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            Console.WriteLine("-------Course--------");
            return $"Name: {Name} \nTitle: {Title} \nCredits: {Credits.ToString("0.0")} \nDescription: {Description}\n";
        }
        public int CompareTo(Course otherCourse)
        {
            return this.Name.CompareTo(otherCourse.Name);
        }
    }
}