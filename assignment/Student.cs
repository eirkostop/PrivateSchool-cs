using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Student
    {
        #region public properties and methods
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double TuitionFees { get; set; }
        public override string ToString()
        {
            return $"\n {this.FirstName} {this.LastName} - {this.DateOfBirth.ToString("yyyy/MM/dd")} - {this.TuitionFees}";
        }
        #endregion

        #region Constructors
        public Student() { }
        public Student(string f, string l, DateTime b, double t)
        {
            this.FirstName = f;
            this.LastName = l;
            this.DateOfBirth = b;
            this.TuitionFees = t;
        } 
        #endregion
    }
}