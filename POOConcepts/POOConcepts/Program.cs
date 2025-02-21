using POOConcepts;

try
{
    var secretary = new SalaryEmployee(1, "Sandra", "Martinez", true, new Date(1981, 11, 14), new Date(2022, 12, 14), 2500000M);
    var manager = new SalaryEmployee(2, "Fabio", "Ochoa", true, new Date(1971, 11, 14), new Date(2002, 12, 14), 11756324.15M);

    var employees = new List<Employee>() { secretary, manager };
    foreach (var employee in employees)
    {
        Console.WriteLine(employee);
        Console.WriteLine("---------------------------------------------");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}