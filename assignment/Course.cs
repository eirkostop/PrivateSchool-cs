using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Course
    {
        #region public properties and methods
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public override string ToString()
        {
            return $"\n {this.Title} - {this.Stream} - {this.Type} - {this.StartDate.ToString("yyyy/MM/dd")} - {this.EndDate.ToString("yyyy/MM/dd")}";
        }
        #endregion

        #region Public Constructors
        public Course() { }
        public Course(string t, string s, string tt, DateTime sd, DateTime ed)
        {
            this.Title = t;
            this.Stream = s;
            this.Type = tt;
            this.StartDate = sd;
            this.EndDate = ed;
        } 
        #endregion
    }
}
