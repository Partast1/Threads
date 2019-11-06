using System;
using System.Collections.Generic;
using System.Text;

namespace EmploymentInheritance
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculateSalaryPerHour(int rank)
        {
            decimal baseAmount = 259;

            Salary = baseAmount + (rank * 6);
        }
      
        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Reviewing performance review");
        }
        public void Firesomeone()
        {
            Console.WriteLine("You are fired.");

        }
    }
}
