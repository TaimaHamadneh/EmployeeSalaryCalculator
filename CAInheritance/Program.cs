Manager m = new Manager(1000, "Taima H.", 166, 20);

Maintanence ms = new Maintanence(1001, "Cedra H.", 182, 8);

Sales s = new Sales(1002, "Moath H.", 200, 10, 0.05m, 10000m);

Developer d = new Developer(1003, "Taima H.", 210, 20, true);


Employee[] employees = { m, ms, s, d };

foreach(var employee in employees)
{
    Console.WriteLine("\n-----------------");
    Console.WriteLine(employee);
}


Console.ReadKey();