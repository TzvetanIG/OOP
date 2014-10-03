namespace CompanyHierarchy.Person.Emloyee
{
    using System.Linq;
    using System.Collections.Generic;

    public class Manager : Employee, IManager
    {
        private IList<IPerson> employees = new List<IPerson>();

        public Manager(string firstName, string lastName, int id, double salary, Department department,
            IList<IPerson> employees)
            : base(firstName, lastName, id, salary, department)
        {
            this.employees = employees;
        }

        public Manager(string firstName, string lastName, int id, double salary, Department department)
            : base(firstName, lastName, id, salary, department)
        {
        }

        public void AddEploymee(IPerson employee)
        {
            this.employees.Add(employee);
        }

        public override string ToString()
        {
            var fullNamesOfEmployees = employees.Select(e => e.FirstName + " " + e.LastName);
            return base.ToString() + "\n" +
                   string.Format("Employees:\n{0}", string.Join("\n", fullNamesOfEmployees));
        }
    }
}

