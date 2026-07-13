public abstract class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public double BaseSalary { get; set; }

    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        BaseSalary = salary;
    }

    public abstract double CalculateSalary();

    public virtual void Display()
    {
        Console.WriteLine($"ID : {Id}");
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Salary : {CalculateSalary()}");
    }
}