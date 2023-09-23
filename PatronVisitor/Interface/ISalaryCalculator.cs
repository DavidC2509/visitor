using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronVisitor.Entities;

namespace PatronVisitor.Interface
{
    public interface ISalaryCalculator
    {
        decimal CalculateSalary(FullTimeEmployee fullTimeEmployee);
        decimal CalculateSalary(PartTimeEmployee partTimeEmployee);
    }
}
