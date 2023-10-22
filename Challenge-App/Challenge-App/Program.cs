using Challenge_App;

Console.WriteLine("Welcome to The Challenger, employee evaluation program.");
Console.WriteLine("_________________________________________________________");
Console.WriteLine();

var employee = new EmployeeInFile("Monika", "Serczyk", 'K', 30);
employee.ToString();
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("New grade has been added");
}

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
    catch (Exception x)
    {
        Console.WriteLine($"exception occurred!!!{x.Message}");
    }

}

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");