using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Trainer
    {
        #region Public/private Properties and Methods
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private readonly string subject;
        public string ClassName = "Trainer" ?? "";
        public override string ToString()
        {
            return $"\n {this.FirstName} {this.LastName} - {this.subject}";
        }
        #endregion

        #region Public Constructors
        public Trainer()
        {

        }
        public Trainer(string f, string l, string s)
        {
            this.FirstName = f;
            this.LastName = l;
            this.subject = s;
        } 
        #endregion
    }
}
