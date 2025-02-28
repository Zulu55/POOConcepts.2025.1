using POOConcepts;

try
{
    var secretary = new SalaryEmployee(1, "Sandra", "Martinez", true, new Date(1981, 11, 14), new Date(2022, 12, 14), 2500000M);
    var manager = new SalaryEmployee(2, "Fabio", "Ochoa", true, new Date(1971, 11, 14), new Date(2002, 12, 14), 11756324.15M);
    var washer = new HourlyEmployee(3, "Jaime", "Betancur", true, new Date(1980, 12, 1), new Date(2020, 4, 20), 178, 10250.56M);
    var salesPerson1 = new ComissionEmployee(4, "Monica", "Gil", true, new Date(1989, 7, 1), new Date(2020, 4, 20), 0.03F, 670000000M);
    var salesPerson2 = new ComissionEmployee(5, "Henry", "Vasquez", true, new Date(1979, 1, 1), new Date(2020, 4, 20), 0.03F, 59000000M);
    var salesPerson3 = new BaseComissionEmployee(6, "Patrica", "Rodriguez", true, new Date(1990, 2, 23), new Date(2025, 1, 10), 0.015F, 97000000M, 650000M);

    var employees = new List<Employee>() { secretary, manager, washer, salesPerson1, salesPerson2, salesPerson3 };
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