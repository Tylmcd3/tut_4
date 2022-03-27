using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_4
{
    class Employee
    {
        public string name;
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
