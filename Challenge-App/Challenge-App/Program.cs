using Challenge_App;

Employee employee = new Employee("Alex", "Mateus");
employee.AddGrade("Adam");
employee.AddGrade("8,99");
employee.AddGrade(7);
employee.AddGrade(31);
employee.AddGrade(9f);
var statistics = employee.GetStatistics();


var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine(employee.Name + " " + employee.Surname); ;
Console.WriteLine($"Average {statistics1.Average:N3}");
Console.WriteLine($"Max {statistics1.Max}");
Console.WriteLine($"Min {statistics1.Min}");

Console.WriteLine(employee.Name + " " + employee.Surname); ;
Console.WriteLine($"Average {statistics2.Average:N3}");
Console.WriteLine($"Max {statistics2.Max}");
Console.WriteLine($"Min {statistics2.Min}");

Console.WriteLine(employee.Name + " " + employee.Surname); ;
Console.WriteLine($"Average {statistics3.Average:N3}");
Console.WriteLine($"Max {statistics3.Max}");
Console.WriteLine($"Min {statistics3.Min}");

Console.WriteLine(employee.Name + " " + employee.Surname); ;
Console.WriteLine($"Average {statistics4.Average:N3}");
Console.WriteLine($"Max {statistics4.Max}");
Console.WriteLine($"Min {statistics4.Min}");