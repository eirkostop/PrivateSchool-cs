using System;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            CoursesList courses = new CoursesList();
            StudentsList students = new StudentsList();
            TrainersList trainers = new TrainersList();
            AssignmentsList assignments = new AssignmentsList();
            new Menu(courses,assignments,students,trainers);
        }
    }
}