namespace POOConcepts;

public class HourlyEmployee : Employee
{
    private int _workingHours;
    private decimal _valueHour;

    public HourlyEmployee(int id, string firstName, string lastName, bool isActive, Date? bornDate, Date? hireDate, int workingHours, decimal valueHour) : base(id, firstName, lastName, isActive, bornDate, hireDate)
    {
        WorkingHours = workingHours;
        ValueHour = valueHour;
    }

    public int WorkingHours { get => _workingHours; set => _workingHours = ValidateWorkingHours(value); }
    public decimal ValueHour { get => _valueHour; set => _valueHour = ValidateValueHour(value); }

    public override string ToString()
    {
        return $"{base.ToString()}\n\t" +
            $"Working hours..: {WorkingHours,20:N2}\n\t" +
            $"Hour value.....: {ValueHour,20:C2}\n\t" +
            $"Value to pay...: {GetValueToPay(),20:C2}";
    }

    public override decimal GetValueToPay()
    {
        return ValueHour * WorkingHours;
    }

    private int ValidateWorkingHours(int workingHours)
    {
        if (workingHours < 0)
        {
            throw new Exception($"The working hours: {workingHours}, is not valid.");
        }
        return workingHours;
    }

    private decimal ValidateValueHour(decimal valueHour)
    {
        if (valueHour < 10000)
        {
            throw new Exception($"The value hour: {valueHour:C2}, is less than $10,000.00.");
        }
        return valueHour;
    }
}