using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class StudentsInMoreCourses : StudentsList
    {
        public StudentsInMoreCourses() { }
        public StudentsInMoreCourses(CoursesList courses)
        {
            for (int i = 0; i < courses.List.Count; i++)
            {
                foreach (Student s in courses.List[i].Students)
                {
                    for (int j = 0; j < courses.List.Count; j++)
                    {
                        foreach (Student ss in courses.List[j].Students)
                        {
                            if (s == ss && i != j && !List.Contains(s))
                            {
                                List.Add(s);
                            }
                        }
                    }
                }
            }
        }
    }
}
