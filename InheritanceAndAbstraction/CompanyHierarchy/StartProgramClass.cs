using System;
using CompanyHierarchy.Person.Emloyee;
using CompanyHierarchy.Person.Emloyee.RegularEmployee;
using CompanyHierarchy.Utilities;

class StartProgramClass
{
    static void Main()
    {
        var superMario = new Product("Super Mario", DateTime.Now, 30);
        var textEditor = new Product("Editor 2014", DateTime.Now, 100);

        var calculator = new Project("Calculator", DateTime.Now);
        var pdfConverter = new Project("PDF converter", DateTime.Now, "Convert text file in PDF");
        pdfConverter.CloseProject();

        var asen = new SalesEmployee("Asen", "Mikov", 10001, 1200, Department.Marketing);
        asen.AddSales(superMario);
        asen.AddSales(textEditor);
        Console.WriteLine(asen);
        Console.WriteLine();

        var ivan = new SalesEmployee("Ivan", "Ivanov", 10002, 1250, Department.Marketing);
        ivan.AddSales(textEditor);
        ivan.AddSales(textEditor);

        var tzvetomir = new Delveloper("Tzvetomir", "Serov", 10003, 1500, Department.Production);
        tzvetomir.AddProject(calculator);
        tzvetomir.AddProject(pdfConverter);

        var dimitrina = new Delveloper("Dimitrima", "Shamanova", 10004, 1600, Department.Production);
        dimitrina.AddProject(calculator);
        dimitrina.AddProject(pdfConverter);
        Console.WriteLine(dimitrina);
        Console.WriteLine();

        var managerGesho = new Manager("Gesho", "Mihailov", 12345, 1800, Department.Marketing);
        managerGesho.AddEploymee(asen);
        managerGesho.AddEploymee(ivan);
        Console.WriteLine(managerGesho);
        Console.WriteLine();

        var managerPesho = new Manager("Pesho", "Milanov", 12346, 1900, Department.Production);
        managerPesho.AddEploymee(dimitrina);
        managerPesho.AddEploymee(tzvetomir);
        Console.WriteLine(managerPesho);
    }
}
