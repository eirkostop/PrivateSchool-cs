using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class TrainersPerCourse : TrainersList
    {
        public TrainersPerCourse() { }
        public TrainersPerCourse(CoursesList courses, string courseTitle)
        {
            bool titleExists = false;
            foreach (Course c in courses.List)
            {
                if (c.Title.ToLower() == courseTitle.ToLower())
                {
                    titleExists = true;
                    foreach (Trainer t in c.Trainers)
                    {
                        List.Add(t);
                    }
                }
            }
            if (titleExists == false)
            {
                Console.WriteLine(" No such course in our school.");
            }
        }
    }
}
