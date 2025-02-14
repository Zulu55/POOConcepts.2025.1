using POOConcepts;

try
{
    var date1 = new Date();
    var date2 = new Date(1974, 12, 3);
    var date3 = new Date(2020, 2, 29);

    date1.Year = 2025;
    date1.Month = 2;
    date1.Day = 13;

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}