using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronVisitor.Entities;

namespace PatronVisitor.Interface
{
    public class SalaryCalculator : ISalaryCalculator
    {

        public decimal TotalSalary { get; private set; }

        public decimal CalculateSalary(FullTimeEmployee fullTimeEmployee)
        {
            TotalSalary += fullTimeEmployee.Salary / fullTimeEmployee.DayWork;
            return TotalSalary;
        }

        public decimal CalculateSalary(PartTimeEmployee partTimeEmployee)
        {
            TotalSalary += partTimeEmployee.HoursWorked * partTimeEmployee.SalaryForHours;

            return TotalSalary;

        }
    }

}
