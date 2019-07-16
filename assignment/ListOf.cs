using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    abstract class ListOf<TypeOfObject>
    {
        public abstract void AddNew();
        public string Title = string.Empty;
        public List<TypeOfObject> List = new List<TypeOfObject>();
        public override string ToString()
        {
            string rows = Title;
            foreach (TypeOfObject o in List)
            {
                rows += o.ToString();
            }
            if (List.Count == 0)
            {
                rows += "\n No entries";
            }
            return rows;
        }
    }
}
