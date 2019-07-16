using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class TrainersList:ListOf<Trainer>
    {
        public TrainersList()
        {
            Title =
                   "\n--------------------------------------------------------------------" +
                   "\n Name   -    Subject                                                " +
                   "\n--------------------------------------------------------------------";
        }
        public override void AddNew()
        {
            Console.Write(" Give trainer's first name:");
            string firstName = Console.ReadLine();
            Console.Write(" Give trainer's last name:");
            string lastName = Console.ReadLine();
            Console.Write(" Give trainer's subject:");
            string subject = Console.ReadLine();
            Console.WriteLine(" Trainer added");
            List.Add(new Trainer(firstName, lastName, subject));
        }
    }
}

