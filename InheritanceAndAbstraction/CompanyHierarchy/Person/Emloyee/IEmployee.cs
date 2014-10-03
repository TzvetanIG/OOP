namespace CompanyHierarchy.Person.Emloyee
{
    public interface IEmployee
    {
        double Salary { get; set; }
        Department Department { get; set; }
    }
}
