using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronVisitor.Entities;

namespace PatronVisitor.Interface
{
    public class ReportVisitor : IReportEmployee
    {
        private ISalaryCalculator salaryCalculator1 = new SalaryCalculator();

        public void Report(FullTimeEmployee fullTimeEmployee)
        {
            Console.WriteLine($"Informe de salario por dia {fullTimeEmployee.Name}: {salaryCalculator1.CalculateSalary(fullTimeEmployee):#.##} BS");
        }

        public void Report(PartTimeEmployee partTimeEmployee)
        {
            Console.WriteLine($"Informe de salaria total {partTimeEmployee.Name}: {salaryCalculator1.CalculateSalary(partTimeEmployee):#.##} BS");
        }
    }
}
