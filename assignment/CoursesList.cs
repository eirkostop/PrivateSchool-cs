using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class CoursesList:ListOf<Course>
    {
        public CoursesList()
        {
            Title =
                "\n--------------------------------------------------------------------" +
                "\n Title - Stream -Type  - Start Date - End Date                      " +
                "\n--------------------------------------------------------------------";
        }
        public override void AddNew()
        {
            Console.Write(" Give course's title:");
            string title = Console.ReadLine();
            Console.Write(" Give course's stream:");
            string stream = Console.ReadLine();
            Console.Write(" Give course's type:");
            string type = Console.ReadLine();
            Console.Write(" Give course's start date (y/m/d):");
            DateTime StartDate;
            while (!DateTime.TryParse(Console.ReadLine(), out StartDate))
            {
                Console.Write("Wrong Input. Enter a valid date (y/m/d):");
            }
            Console.Write(" Give course's end date (y/m/d):");
            DateTime endDate;
            while (!DateTime.TryParse(Console.ReadLine(), out endDate))
            {
                Console.Write("Wrong Input. Enter a valid date (y/m/d):");
            }
            Console.WriteLine(" Course added");
            List.Add(new Course(title, stream, type, StartDate, endDate));
        }
        public void AddToCourse(Student s, Trainer t, Assignment a)
        {
            if (List.Count != 0)
            {
                Console.Write(" Add to available courses (y for yes)?");
                string answer = Console.ReadLine();
                while (answer == "y")
                {
                    Console.Write(ToString() + "\n Choose course name: ");
                    string courseTitle = Console.ReadLine();
                    bool titleExists = false;
                    foreach (Course c in List)
                    {
                        if (courseTitle.ToLower() == c.Title.ToLower())
                        {
                            titleExists=true;
                            if (s != null && !c.Students.Contains(s)) c.Students.Add(s);
                            if (t != null && !c.Trainers.Contains(t)) c.Trainers.Add(t);
                            if (a != null && !c.Assignments.Contains(a)) c.Assignments.Add(a);
                            Console.WriteLine($" Added.");
                        }
                    }
                    if (!titleExists)
                    {
                        Console.WriteLine(" No such course in our school.");
                    }
                    Console.Write(" Add to another course (y for yes)? ");
                    answer = Console.ReadLine();
                }
            }
        }
    }
}