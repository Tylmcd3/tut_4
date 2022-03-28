using System;
namespace Tut_4
{
	public class Boss
	{
		public List<Employee> staff = Agency.Generate();

		public void Display()
		{
			foreach (Employee employee in staff)
			{
				employee.PrintEmployee();

			}
		}

		public Employee Use(int id)
		{
			foreach (Employee employee in staff)
			{
				if (employee.id == id)
				{
					return employee;
				}

			}
			return new Employee { id = 0, gender = Gender.X, Name = "Not found" };

		}

		public Employee Fire(int id)
		{
			Employee fired = new Employee { id = 0, gender = Gender.X, Name = "Not found" };
			foreach (Employee employee in staff)
			{
				if (employee.id == id)
				{
					fired = employee;
				}

			}

			if (staff.Remove(fired))
			{
				return fired;
			}
			else
			{
				return fired;
			}
		}
	}
}