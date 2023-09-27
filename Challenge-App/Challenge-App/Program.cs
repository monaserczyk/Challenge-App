using Challenge_App;

Employee employee = new Employee("Alex", "Mateus");
employee.AddGrade("Adam");
employee.AddGrade("8,99");
employee.AddGrade(7);
employee.AddGrade(31);
employee.AddGrade(9f);
var statistics = employee.GetStatistics();


var statisticsForEachLoop = employee.GetStatisticsWithForEach();
var statisticsForLoop = employee.GetStatisticsWithFor();
var statisticsDoWhileLoop = employee.GetStatisticsWithDoWhile();
var statisticsWhileLoop = employee.GetStatisticsWithWhile();

Console.WriteLine(employee.Name + " " + employee.Surname);
Console.WriteLine($"Average {statisticsForEachLoop.Average:N3}");
Console.WriteLine($"Max {statisticsForEachLoop.Max}");
Console.WriteLine($"Min {statisticsForEachLoop.Min}");

Console.WriteLine(employee.Name + " " + employee.Surname);
Console.WriteLine($"Average {statisticsForLoop.Average:N3}");
Console.WriteLine($"Max {statisticsForLoop.Max}");
Console.WriteLine($"Min {statisticsForLoop.Min}");

Console.WriteLine(employee.Name + " " + employee.Surname);
Console.WriteLine($"Average {statisticsDoWhileLoop.Average:N3}");
Console.WriteLine($"Max {statisticsDoWhileLoop.Max}");
Console.WriteLine($"Min {statisticsDoWhileLoop.Min}");

Console.WriteLine(employee.Name + " " + employee.Surname);
Console.WriteLine($"Average {statisticsWhileLoop.Average:N3}");
Console.WriteLine($"Max {statisticsWhileLoop.Max}");
Console.WriteLine($"Min {statisticsWhileLoop.Min}");