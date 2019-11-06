using System;
using System.Collections.Generic;
using System.Text;

namespace EmploymentInheritance
{
    public abstract class BaseEmployee : IEmployee
    {
        private string firstName;
        private string lastName;
        private decimal salary;

        public string Firstname
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LatName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public virtual void CalculateSalaryPerHour(int rank)
        {
            decimal baseAmount = 113;

            Salary = baseAmount + (rank * 2);

        }
    }
}
