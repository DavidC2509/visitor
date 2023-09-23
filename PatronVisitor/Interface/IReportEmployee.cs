using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronVisitor.Entities;

namespace PatronVisitor.Interface
{
    public interface IReportEmployee
    {
        void Report(FullTimeEmployee fullTimeEmployee);
        void Report(PartTimeEmployee partTimeEmployee);
    }
}
