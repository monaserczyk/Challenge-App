using Challenge_App;

Console.WriteLine("Welcome to The Challenger, employee evaluation program.");
Console.WriteLine("_________________________________________________________");
Console.WriteLine();

Console.WriteLine("Provide an employee name.");
var employeename = Console.ReadLine();
Console.WriteLine("Provide an employee surname.");
var employeesurname = Console.ReadLine();
var employee = new Employee(employeename, employeesurname);
Console.WriteLine(employee.Name);
Console.WriteLine(employee.Surname);

while (true)
{
    Console.WriteLine("Provide an employee rating.");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception x)
    {
        Console.WriteLine($"Exception occurred!!!{x.Message}");
    }
    
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");