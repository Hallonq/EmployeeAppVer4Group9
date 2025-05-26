using EmployeesApp.Application;
using EmployeesApp.Application.Employees;

public class Program
{
    static void Main(string[] args)
    {
        EmployeeService employeeService = new EmployeeService();
        var employees = employeeService.GetAll();
        foreach (var employee in employees)
            Console.WriteLine(employee.Name);

        Console.Write("Input user id");
        string input = Console.ReadLine();
        int id = int.Parse(input);
        Console.WriteLine(employeeService.GetById(id).Name);
    }

    private void PrintAllEmployees()
    {

    }
}
