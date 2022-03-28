using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_4
{
    public delegate Employee ManageWorker(int id);
    class Program
    {
        static List<Employee> FilterByGender(List<Employee> staff, Gender gender)
        {
            List<Employee> filteredStaff = new List<Employee>();
            foreach (Employee employee in staff)
            {
                if (employee.gender == gender)
                {
                    filteredStaff.Add(employee);
                }
            }
            return filteredStaff;
        }


        static void Main(string[] args)
        {
            Boss boss = new Boss();
            Action doSomething = boss.Display;
            ManageWorker manage = boss.Use;
            ManageWorker rid = boss.Fire;

            doSomething();
            Console.WriteLine("Dealing with {0}", manage(1));
            Console.WriteLine("Firing {0}", rid(2));
            doSomething();
        }
    }
}
