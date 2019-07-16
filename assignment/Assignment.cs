using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Assignment
    {
        #region public properties and methods
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime SubDateTime { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }
        public override string ToString()
        {
            return $"\n {this.Title} - {this.Description} - {this.Type} - {this.SubDateTime.ToString("yyyy/MM/dd")} - {this.OralMark} - {this.TotalMark}";
        }
        #endregion

        #region Constructors
        public Assignment() { }
        public Assignment(string t, string d, string tt, DateTime s, double oral, double total)
        {
            this.Title = t;
            this.Description = d;
            this.Type = tt;
            this.SubDateTime = s;
            this.OralMark = oral;
            this.TotalMark = total;
        } 
        #endregion
    }
}
