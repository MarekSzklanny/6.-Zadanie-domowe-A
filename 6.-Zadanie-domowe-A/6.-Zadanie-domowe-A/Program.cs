using _6._Zadanie_domowe_A;

Employee employee1 = new Employee("Jan", "Kowalski", 25);
Employee employee2 = new Employee("Anna", "Zawada", 30);
Employee employee3 = new Employee("Andrzej", "Nowak", 29);

employee1.AddScore(1);
employee1.AddScore(7);
employee1.AddScore(2);
employee1.AddScore(5);
employee1.AddScore(1);

employee2.AddScore(4);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(9);
employee2.AddScore(8);

employee3.AddScore(9);
employee3.AddScore(7);
employee3.AddScore(5);
employee3.AddScore(3);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
    {
        employee1, employee2, employee3
    };
var maxResult = 0;

Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee1.Result > maxResult)
    {
        employeeWithMaxResult = employee1;
        maxResult = employee1.Result;
    }
    else if (employee2.Result > maxResult)
    {
        employeeWithMaxResult = employee2;
        maxResult = employee2.Result;
    }
    else if (employee3.Result > maxResult)
    {
        employeeWithMaxResult = employee3;
        maxResult = employee3.Result;
    }
}
Console.WriteLine($"Najwięcej punktów: {maxResult} zdobywa {employeeWithMaxResult.Name} {employeeWithMaxResult.Surname}, lat: {employeeWithMaxResult.Age}");
