using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_4
{
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

        }
    }
}
