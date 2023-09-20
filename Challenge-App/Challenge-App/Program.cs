using Challenge_App;

Employee employee1 = new Employee("Alex","Matus","38");
Employee employee2 = new Employee("Luis","Italicus","33");
Employee employee3 = new Employee("Rita","Kitty","25");


employee1.AddScore(9);
employee1.AddScore(7);
employee1.AddScore(10);

employee2.AddScore(5);
employee2.AddScore(8);
employee2.AddScore(6);

employee3.AddScore(1);
employee3.AddScore(3);
employee3.AddScore(2);



List<Employee> employees = new List<Employee>()
{
    employee1,employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
var name = employeeWithMaxResult.Name;
var surname = employeeWithMaxResult.Surname;    
var age = employeeWithMaxResult.Age;
var result = employeeWithMaxResult.Result;



Console.WriteLine
    (" Pracownik z najlepszym wynikiem" + "  " + name + " " + surname + "  " + age + "lat " + "otrzymal/a " + maxResult + "punktow.");  

