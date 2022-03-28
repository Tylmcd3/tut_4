namespace Tut_4
{
    public abstract class Agency{
        public List<Employee> Generate(){
            List<Employee> employees = new List<Employee>(){
                new Employee { Name = "Joe", id = 1, gender = Gender.M },
                new Employee { Name = "Jane", id = 2, gender = Gender.F },
                new Employee { Name = "Jim", id = 3, gender = Gender.M },
                new Employee { Name = "Joanne", id = 4, gender = Gender.F },
                new Employee { Name = "James", id = 5, gender = Gender.M },
                new Employee { Name = "Jean", id = 6, gender = Gender.F}
            };
            return employees;
        }
    }
}