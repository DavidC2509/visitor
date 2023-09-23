using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronVisitor.Interface;

namespace PatronVisitor.Entities
{
    public class PartTimeEmployee : Employee
    {
        public decimal SalaryForHours { get; set; }

        public int HoursWorked { get; set; }


        public override void CalculateReport(IReportEmployee visitor)
        {
            visitor.Report(this);
        }

        public override void CalculateSalary(ISalaryCalculator visitor)
        {
            visitor.CalculateSalary(this);
        }
    }
}