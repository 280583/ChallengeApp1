using ChallengeApp1;

var employee1 = new Employee(name: "Henryk", surname: "komputer", age:40);
var employee2 = new Employee(name: "anna", surname: "Majka", age: 38);
var employee3 = new Employee(name: "Kamil", surname: "Kowalski", age: 34);

var employees = new List<Employee> { employee1, employee2, employee3 };

employee1.AddGrade(10);
employee1.AddGrade(9);
employee1.AddGrade(9);
employee1.AddGrade(10);
employee1.AddGrade(5);

employee2.AddGrade(10);
employee2.AddGrade(9);
employee2.AddGrade(90);
employee2.AddGrade(10);
employee2.AddGrade(8);

employee3.AddGrade(10);
employee3.AddGrade(9);
employee3.AddGrade(9);
employee3.AddGrade(10);
employee3.AddGrade(7);

var employeWithMaxScore = GetEmployeeWithMaxScore(employees);

Console.WriteLine($"Employee with the higheast grade is {employeeWithMaxScore.Name} " +;
                  $"{employeeWithMaxScore. Surname} - {employeeWithxcore. Result} points");

static Employee GetEmployeeWithMaxScore(List<Employee> emploees)
{
    var maxResult = 0;
    Employee employeeWithMaxScore = null!;

    foreach (var employee in employees)
    {
        maxResult = Math.Max(employee.Result, maxResult);
        if (maxResult == employee.Result)
        {
            employeeWithMaxScore = employee;
        }
    }

    retrun employeeWithMaxScore;
}