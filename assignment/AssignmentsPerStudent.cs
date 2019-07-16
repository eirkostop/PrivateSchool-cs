using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class AssignmentsPerStudent : AssignmentsList
    {
        public AssignmentsPerStudent() { }
        public AssignmentsPerStudent(CoursesList courses, string firstname, string lastname)
        {
            bool nameExists = false;
            foreach (Course c in courses.List)
            {
                foreach (Student s in c.Students)
                {
                    if (s.LastName.ToLower() == lastname.ToLower() && s.FirstName.ToLower() == firstname.ToLower())
                    {
                        nameExists = true;
                        foreach (Assignment a in c.Assignments)
                        {
                            if (!List.Contains(a))
                            {
                                List.Add(a);
                            }
                        }
                    }
                }
            }
            if (!nameExists)
            {
                Console.WriteLine(" No such student in our school.");
            }
        }
    }
}
