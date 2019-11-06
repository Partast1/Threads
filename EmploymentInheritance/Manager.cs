using System;
using System.Collections.Generic;
using System.Text;

namespace EmploymentInheritance
{
    public class Manager : Employee, IManager
    {
        public override void CalculateSalaryPerHour(int rank)
        {
            decimal baseAmount = 143;

            Salary = baseAmount + (rank * 4);
        }
        public void GeneratePerformanceReview()
        {
            //simulating reviewing a report
            Console.WriteLine("Reviewing performance review");
        }
    }   
}
