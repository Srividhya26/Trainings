using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class EmployeeDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }

        Hashtable _employee = new Hashtable();

        public EmployeeDetails()
        {

        }
        public EmployeeDetails(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
       
        public string this[int id]
        { 
            get {
                return (string)_employee[id] ;
            }
            set
            {
                _employee.Add(id,value);
            }
        }
    }
}
