using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class AssignmentsList: ListOf<Assignment>
    {
        public AssignmentsList()
        {
            Title =
                "\n--------------------------------------------------------------------" +
                "\n Title - Description -Type - Submission Date - Oral Mark- Total Mark" +
                "\n--------------------------------------------------------------------";
        }
        public override void AddNew()
        {
            Console.Write(" Give assignment's title:");
            string title = Console.ReadLine();
            Console.Write(" Give assignment's description:");
            string description = Console.ReadLine();
            Console.Write(" Give assignment's type:");
            string type = Console.ReadLine();
            Console.Write(" Give submission date (y/m/d):");
            DateTime subDate;
            while (!DateTime.TryParse(Console.ReadLine(), out subDate))
            {
                Console.Write(" Wrong Input. Enter a valid date (y/m/d):");
            }
            Console.Write(" Give oral Mark:");
            double oral;
            while (!Double.TryParse(Console.ReadLine(), out oral))
            {
                Console.Write(" Wrong Input. Enter a number:");
            }
            Console.Write(" Give total Mark:");
            double total;
            while (!Double.TryParse(Console.ReadLine(), out total))
            {
                Console.Write(" Wrong Input. Enter a number:");
            }
            Console.WriteLine(" Assignment added");
            List.Add(new Assignment(title, description, type, subDate, oral, total));
        }
    }
}

