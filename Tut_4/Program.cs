using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut_4
{
    class Program
    {
        static List<Employee> CreateEmployeeList()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { name = "Joe", id = 1, gender = Gender.M });
            employees.Add(new Employee { name = "Jane", id = 2, gender = Gender.F });
            employees.Add(new Employee { name = "Jim", id = 3, gender = Gender.M });
            employees.Add(new Employee { name = "Joanne", id = 4, gender = Gender.F });
            employees.Add(new Employee { name = "James", id = 5, gender = Gender.M });
            employees.Add(new Employee { name = "Jean", id = 6, gender = Gender.F });

            return employees;
        }

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
            // Display the num
            List<Employee> employees = CreateEmployeeList();

            List<Employee> FilteredEmployees = FilterByGender(employees, Gender.M);

            foreach (Employee employee in employees)
            {
                employee.PrintEmployee();

            }
        }
    }
}