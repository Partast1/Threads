namespace EmploymentInheritance
{
    public interface IEmployee
    {
        string Firstname { get; set; }
        string LatName { get; set; }
        decimal Salary { get; set; }
        void CalculateSalaryPerHour(int rank);
    }
}