using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Menu
    {
        #region navigation
        private readonly string options =
       "\n********************************************************************" +
       " \n 1: import sample data |  9: list all assignments " +
       " \n 2: add new student    | 10: list students per course " +
       " \n 3: add new trainer    | 11: list trainers per course " +
       " \n 4: add new course     | 12: list assignments per course " +
       " \n 5: add new assignment | 13: list assignments per student " +
       " \n 6: list all students  | 14: list students in more than one course" +
       " \n 7: list all trainers  | 15: check submission dates " +
       " \n 8: list all courses   | 16: exit " +
       "\n********************************************************************" +
       "\n Please choose an action from the menu (1-16):";
        private readonly bool exit = false;
        private readonly bool sampleDataImported = false;
        #endregion

        #region actions
        public Menu() { }
        public Menu(CoursesList courses, AssignmentsList assignments, StudentsList students, TrainersList trainers)
        {
            Console.WriteLine(" Welcome to our school!");
            while (!exit)
            {
                Console.Write(options);
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        if (!sampleDataImported)
                        {
                            Synthetic sample = new Synthetic();
                            sample.Create();
                            students.List.AddRange(sample.Students.List);
                            trainers.List.AddRange(sample.Trainers.List);
                            assignments.List.AddRange(sample.Assignments.List);
                            courses.List.AddRange(sample.Courses.List);
                            Console.WriteLine("\n Sample Data imported.");
                            sampleDataImported = true;
                        }
                        else
                        {
                            Console.WriteLine("\n You have already imported sample data.");
                        }
                        break;
                    case "2":
                        students.AddNew();
                        courses.AddToCourse(students.List[students.List.Count-1],null,null);
                        break;
                    case "3":
                        trainers.AddNew();
                        courses.AddToCourse(null,trainers.List[ trainers.List.Count - 1],null);
                        break;
                    case "4":
                        courses.AddNew();
                        break;
                    case "5":
                        assignments.AddNew();
                        courses.AddToCourse(null, null, assignments.List[assignments.List.Count - 1]);
                        break;
                    case "6":
                        Console.WriteLine(students.ToString());
                        break;
                    case "7":
                        Console.WriteLine(trainers.ToString());
                        break;
                    case "8":
                        Console.WriteLine(courses.ToString());
                        break;
                    case "9":
                        Console.WriteLine(assignments.ToString());
                        break;
                    case "10":
                        Console.Write(" Give course title:");
                        string courseTitle = Console.ReadLine();
                        StudentsPerCourse studentsPerCourse = new StudentsPerCourse(courses, courseTitle);
                        Console.WriteLine(studentsPerCourse.ToString());
                        break;
                    case "11":
                        Console.Write(" Give course title:");
                        courseTitle = Console.ReadLine();
                        TrainersPerCourse trainersPerCourse = new TrainersPerCourse(courses, courseTitle);
                        Console.WriteLine(trainersPerCourse.ToString());
                        break;
                    case "12":
                        Console.Write(" Give course title:");
                        courseTitle = Console.ReadLine();
                        AssignmentsPerCourse assignmentsPerCourse = new AssignmentsPerCourse(courses, courseTitle);
                        Console.WriteLine(assignmentsPerCourse.ToString());
                        break;
                    case "13":
                        Console.Write(" Give student's  first name:");
                        string firstname = Console.ReadLine();
                        Console.Write(" Give student's last name:");
                        string lastname = Console.ReadLine();
                        AssignmentsPerStudent assignmentsPerStudent = new AssignmentsPerStudent(courses, firstname, lastname);
                        Console.WriteLine(assignmentsPerStudent.ToString());
                        break;
                    case "14":
                        StudentsInMoreCourses studentsInMoreCourses = new StudentsInMoreCourses(courses);
                        Console.WriteLine(studentsInMoreCourses.ToString());
                        break;
                    case "15":
                        Console.Write(" Give a date (y/m/d):");
                        DateTime date;
                        while (!DateTime.TryParse(Console.ReadLine(), out date))
                        {
                            Console.Write("Wrong Input. Enter a valid date (y/m/d):");
                        }
                        StudentsWithSubmission studentsWithSubmission = new StudentsWithSubmission(courses, date);
                        Console.WriteLine(" Students submitting assignments"+
                            $"\n from {studentsWithSubmission.StartDate:D} to {studentsWithSubmission.StartDate.AddDays(4):D}:");
                        Console.WriteLine(studentsWithSubmission.ToString());
                        break;
                    case "16":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input.");
                        break;
                }
            }
        } 
        #endregion
    }
}
