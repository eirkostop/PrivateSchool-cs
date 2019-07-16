using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class StudentsList : ListOf<Student>
    {
        public StudentsList()
        {
        Title =
            "\n--------------------------------------------------------------------" +
            "\n Name - Date of Birth  -Tuition Fees                                " +
            "\n--------------------------------------------------------------------";
        }
        public override void AddNew()
        {
            Console.Write(" Give student's first name:");
            string firstName = Console.ReadLine();
            Console.Write(" Give student's last name:");
            string lastName = Console.ReadLine();
            Console.Write(" Give student's date of birth (y/m/d):");
            DateTime dateOfBirth;
            while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
            {
                Console.Write(" Wrong Input. Enter a valid date (y/m/d):");
            }
            Console.Write(" Give student's tuition fees:");
            double tuitionFees;
            while (!Double.TryParse(Console.ReadLine(), out tuitionFees))
            {
                Console.Write(" Wrong Input. Enter a number:");
            }
            Console.WriteLine(" Student Added.");
            List.Add(new Student(firstName, lastName, dateOfBirth, tuitionFees));
        }
    }
}