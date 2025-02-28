using POOConcepts;

try
{
    var secretary = new SalaryEmployee(1, "Sandra", "Martinez", true, new Date(1981, 11, 14), new Date(2022, 12, 14), 2500000M);
    var manager = new SalaryEmployee(2, "Fabio", "Ochoa", true, new Date(1971, 11, 14), new Date(2002, 12, 14), 11756324.15M);
    var washer = new HourlyEmployee(3, "Jaime", "Betancur", true, new Date(1980, 12, 1), new Date(2020, 4, 20), 178, 10250.56M);

    var employees = new List<Employee>() { secretary, manager, washer };
    var total = 0M;
    foreach (var employee in employees)
    {
        Console.WriteLine(employee);
        Console.WriteLine("---------------------------------------------");
        total += employee.GetValueToPay();
    }
    Console.WriteLine($"TOTAL..................: {total,20:C2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}