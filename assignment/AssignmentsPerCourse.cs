using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class AssignmentsPerCourse : AssignmentsList 
    {
        public AssignmentsPerCourse() { }
        public AssignmentsPerCourse(CoursesList courses,string courseTitle)
        {
            bool titleExists = false;
            foreach (Course c in courses.List)
            {
                if (c.Title.ToLower() == courseTitle.ToLower())
                {
                    titleExists = true;
                    foreach (Assignment a in c.Assignments)
                    {
                        List.Add(a);
                    }
                }
            }

            if (!titleExists)
            {
                Console.WriteLine(" No such course in our school.");
            }
        }
    }
}
