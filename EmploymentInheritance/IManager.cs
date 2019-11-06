using System;
using System.Collections.Generic;
using System.Text;

namespace EmploymentInheritance
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
