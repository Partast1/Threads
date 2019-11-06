using System;

namespace EmploymentInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager supervisor1 = new Manager();

            supervisor1.Firstname = "Ole";
            supervisor1.LatName = "Bentsen";
            supervisor1.CalculateSalaryPerHour(4);

            Employee emp01 = new Manager();

            emp01.Firstname = "Ulla";
            emp01.LatName = "Martinsen";
            emp01.AssignManager(supervisor1);
            emp01.CalculateSalaryPerHour(2);


            Console.WriteLine($"{ emp01.Firstname}'s salary is ${ emp01.Salary}/hour.");
            Console.WriteLine($"{ emp01.Firstname}'s salary is ${ emp01.Salary}/hour.");

            Console.ReadLine();
        }
    }
}
