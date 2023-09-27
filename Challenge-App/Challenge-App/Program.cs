using Challenge_App;

Employee employee = new Employee("Alex", "Mateus");
employee.AddGrade("Adam");
employee.AddGrade("8,99");
employee.AddGrade(7);
employee.AddGrade(31);
employee.AddGrade(9f);
var statistics = employee.GetStatistics();

Console.WriteLine(employee.Name + " " + employee.Surname); ;
Console.WriteLine($"Average {statistics.Average:N3}");
Console.WriteLine($"Max {statistics.Max}");
Console.WriteLine($"Min {statistics.Min}");
