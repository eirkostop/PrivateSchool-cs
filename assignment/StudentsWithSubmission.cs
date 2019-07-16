using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class StudentsWithSubmission : StudentsList
    {
        public DateTime StartDate { get; set; }
        public StudentsWithSubmission() { }
        public StudentsWithSubmission(CoursesList courses, DateTime date)
        {
            StartDate = date;
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    StartDate = date.AddDays(0);
                    break;
                case DayOfWeek.Tuesday:
                    StartDate = date.AddDays(-1);
                    break;
                case DayOfWeek.Wednesday:
                    StartDate = date.AddDays(-2);
                    break;
                case DayOfWeek.Thursday:
                    StartDate = date.AddDays(-3);
                    break;
                case DayOfWeek.Friday:
                    StartDate = date.AddDays(-4);
                    break;
                case DayOfWeek.Saturday:
                    StartDate = date.AddDays(-5);
                    break;
                case DayOfWeek.Sunday:
                    StartDate = date.AddDays(-6);
                    break;
                default:
                    break;
            }

            foreach (Course c in courses.List)
            {
                foreach(Assignment a in c.Assignments)
                {
                    if (a.SubDateTime >= StartDate && a.SubDateTime < StartDate.AddDays(5))
                    {
                        foreach (Student s in c.Students)
                        {
                            if (!List.Contains(s))
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
