// See https://aka.ms/new-console-template for more information
using PatronVisitor.Entities;
using PatronVisitor.Interface;

Console.WriteLine("Patron Visitor!");

var employees = new List<Employee>
{
    new FullTimeEmployee { Name = "Juan", Salary = 50000, DayWork = 30 },
    new PartTimeEmployee { Name = "Maria", HoursWorked = 8, SalaryForHours = 15 }
};

var reportVisitor = new ReportVisitor();


foreach (var employee in employees)
{
    employee.CalculateReport(reportVisitor);

}

