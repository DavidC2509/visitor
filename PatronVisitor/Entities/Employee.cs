using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronVisitor.Interface;

namespace PatronVisitor.Entities
{
    public abstract class Employee
    {
        public required string Name { get; set; }
        public abstract void CalculateReport(IReportEmployee visitor);
        public abstract void CalculateSalary(ISalaryCalculator visitor);

    }
}
