using System.Collections.Generic;

namespace Courses
{
  public class CourseCreditComparer : IComparer<Course>
    {
        public int Compare(Course x, Course y)
        {
            double diff = x.Credits - y.Credits;

            if (diff > 0) {
              return 1;
            }
            else if (diff < 0)
            {
              return -1;
            }
            else 
            {
              return 0;
            }
        }
    }
    
}
