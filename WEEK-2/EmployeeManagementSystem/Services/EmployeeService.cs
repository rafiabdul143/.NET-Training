using System.Linq;

public class EmployeeService : IEmployeeService
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public void ViewEmployees()
    {
        foreach (var emp in employees)
        {
            emp.Display();
            Console.WriteLine("--------------------");
        }
    }

    public void SearchEmployee(int id)
    {
        var emp = employees.FirstOrDefault(e => e.Id == id);

        if (emp == null)
        {
            Console.WriteLine("Employee not found.");
            return;
        }

        emp.Display();
    }

    public void UpdateEmployee(int id)
    {
        var emp = employees.FirstOrDefault(e => e.Id == id);

        if (emp == null)
        {
            Console.WriteLine("Employee not found.");
            return;
        }

        Console.Write("Enter New Name: ");
        emp.Name = Console.ReadLine();

        Console.Write("Enter New Salary: ");
        emp.BaseSalary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Updated Successfully");
    }

    public void DeleteEmployee(int id)
    {
        var emp = employees.FirstOrDefault(e => e.Id == id);

        if (emp == null)
        {
            Console.WriteLine("Employee not found.");
            return;
        }

        employees.Remove(emp);

        Console.WriteLine("Deleted Successfully");
    }
}