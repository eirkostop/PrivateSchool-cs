using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Synthetic
    {
        public StudentsList Students = new StudentsList();
        public TrainersList Trainers = new TrainersList();
        public AssignmentsList Assignments = new AssignmentsList();
        public CoursesList Courses = new CoursesList();
        public void Create()
        {
            //Create some Students
            Students.List.Add(new Student("John", "Doe", new DateTime(1991, 5, 5), 2250));
            Students.List.Add(new Student("Sarah", "Doe", new DateTime(1991, 12, 5), 2400));
            Students.List.Add(new Student("George", "Doe", new DateTime(1991, 6, 5), 2500));
            Students.List.Add(new Student("Anna", "Doe", new DateTime(1991, 12, 3), 2500));
            Students.List.Add(new Student("John", "Smith", new DateTime(1991, 12, 3), 2400));
            Students.List.Add(new Student("Sarah", "Smith", new DateTime(1991, 1, 5), 2500));
            Students.List.Add(new Student("George", "Smith", new DateTime(1991, 2, 10), 2500));
            Students.List.Add(new Student("Anna", "Smith", new DateTime(1991, 12, 3), 2500));
            Students.List.Add(new Student("John", "Curie", new DateTime(1991, 1, 3), 2500));
            Students.List.Add(new Student("Sarah", "Curie", new DateTime(1991, 10, 7), 2400));
            Students.List.Add(new Student("George", "Curie", new DateTime(1991, 4, 11), 2500));
            Students.List.Add(new Student("Anna", "Curie", new DateTime(1991, 11, 13), 2250));

            // Create some trainers
            Trainers.List.Add(new Trainer("Albert", "Einstein", "Physics"));
            Trainers.List.Add(new Trainer("Max", "Planck", "Mathematics"));
            Trainers.List.Add(new Trainer("Niels", "Bohr", "Physics"));
            Trainers.List.Add(new Trainer("Enrico", "Fermi", "Chemistry"));

            //Create some assignments
            Assignments.List.Add(new Assignment("Matrices", "Description", "Individual Project", new DateTime(2019, 5, 30), 50, 100));
            Assignments.List.Add(new Assignment("Tensor Analysis", "Description", "Individual Project", new DateTime(2019, 6, 28), 50, 100));
            Assignments.List.Add(new Assignment("Non Linear Algebra", "Description", "Group Project", new DateTime(2019, 7, 26), 50, 100));
            Assignments.List.Add(new Assignment("Vector Analysis", "Description", "Group Project", new DateTime(2019, 8, 30), 50, 100));

            //create some courses
            Courses.List.Add(new Course("Physics", "Fluid Dynamics", "Full Time", new DateTime(2019, 6, 30), new DateTime(2019, 7, 30)));
            Courses.List.Add(new Course("Mathematics", "Algebra", "Part Time", new DateTime(2019, 6, 30), new DateTime(2019, 7, 30)));
            Courses.List.Add(new Course("Chemistry", "Organic", "Full Time", new DateTime(2019, 6, 30), new DateTime(2019, 7, 30)));
            Courses.List.Add(new Course("Biology", "Genetics", "Part Time", new DateTime(2019, 6, 30), new DateTime(2019, 7, 30)));

            //enroll students to courses
            Courses.List[0].Students.Add(Students.List[0]);
            Courses.List[0].Students.Add(Students.List[1]);
            Courses.List[0].Students.Add(Students.List[2]);
            Courses.List[0].Students.Add(Students.List[3]);
            Courses.List[1].Students.Add(Students.List[4]);
            Courses.List[1].Students.Add(Students.List[5]);
            Courses.List[1].Students.Add(Students.List[6]);
            Courses.List[1].Students.Add(Students.List[7]);
            Courses.List[2].Students.Add(Students.List[8]);
            Courses.List[2].Students.Add(Students.List[9]);
            Courses.List[2].Students.Add(Students.List[5]);
            Courses.List[2].Students.Add(Students.List[4]);
            Courses.List[3].Students.Add(Students.List[0]);
            Courses.List[3].Students.Add(Students.List[1]);
            Courses.List[3].Students.Add(Students.List[10]);
            Courses.List[3].Students.Add(Students.List[11]);

            //assign trainers to courses
            Courses.List[0].Trainers.Add(Trainers.List[0]);
            Courses.List[0].Trainers.Add(Trainers.List[2]);
            Courses.List[1].Trainers.Add(Trainers.List[1]);
            Courses.List[1].Trainers.Add(Trainers.List[3]);
            Courses.List[2].Trainers.Add(Trainers.List[0]);
            Courses.List[3].Trainers.Add(Trainers.List[1]);

            //assign assignments to courses
            Courses.List[0].Assignments.Add(Assignments.List[1]);
            Courses.List[0].Assignments.Add(Assignments.List[2]);
            Courses.List[1].Assignments.Add(Assignments.List[2]);
            Courses.List[1].Assignments.Add(Assignments.List[3]);
            Courses.List[2].Assignments.Add(Assignments.List[3]);
            Courses.List[3].Assignments.Add(Assignments.List[0]);
            Courses.List[3].Assignments.Add(Assignments.List[1]);
        }
    }
}
