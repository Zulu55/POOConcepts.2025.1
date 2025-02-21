namespace POOConcepts;

public class SalaryEmployee : Employee
{
    private decimal _salary;

    public SalaryEmployee(int id, string firstName, string lastName, bool isActive, Date? bornDate, Date? hireDate, decimal salary) : base(id, firstName, lastName, isActive, bornDate, hireDate)
    {
        Salary = salary;
    }

    public decimal Salary { get => _salary; set => _salary = ValidateSalary(value); }

    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
            $"Value to pay...: {GetValueToPay(),20:C2}";
    }

    public override decimal GetValueToPay()
    {
        return Salary;
    }

    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 1000000)
        {
            throw new Exception($"The salary: {salary:C2}, is less than the minimun.");
        }
        return salary;
    }
}