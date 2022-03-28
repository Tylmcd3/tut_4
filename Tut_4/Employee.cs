using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_4
{
    public class Employee
    {   
        private string name;
        public string Name {
            get {
                return name;
            }
            set {
                if (value != null) {
                    name = value;
                }
            }
        }
        public int id;
        public Gender gender;

        public override string ToString()
        {
            return ("Name: " + name + ", ID: " + id + ", Gender: " + gender);
        }

        public void PrintEmployee()
        {
            Console.WriteLine(ToString());
        }
    }
} 
