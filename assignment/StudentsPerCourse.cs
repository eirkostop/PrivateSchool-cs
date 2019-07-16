using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class StudentsPerCourse : StudentsList
    {
        public StudentsPerCourse() { }
        public StudentsPerCourse(CoursesList courses, string courseTitle)
        {
            bool titleExists = false;
            foreach (Course c in courses.List)
            {
                if (c.Title.ToLower() == courseTitle.ToLower())
                {
                    titleExists = true;
                    foreach (Student s in c.Students)
                    {
                        if (!List.Contains(s))
                        {
                            List.Add(s);
                        }
                    }
                }
            }
            if (!titleExists)
            {
                Console.WriteLine("No such course in our school.");
            }
        }
    }
}
