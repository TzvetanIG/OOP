using System;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WorkHoursPerDay = workHoursPerDay;
        this.WeekSalary = weekSalary;
    }

    public decimal WorkHoursPerDay
    {
        get { return workHoursPerDay; }

        set
        {
            Validation.CheckForNegativeOrZero(value, "workHoursPerDay");
            workHoursPerDay = value;
        }
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }

        set
        {
            Validation.CheckForNegativeOrZero(value, "weekSalary");
            weekSalary = value;
        }
    }

    public decimal MoneyPerHour()
    {
        return this.WeekSalary / (this.WorkHoursPerDay * 5);
    }

    public override string ToString()
    {
        return base.ToString() + " - " + this.MoneyPerHour().ToString("f2");
    }
}

