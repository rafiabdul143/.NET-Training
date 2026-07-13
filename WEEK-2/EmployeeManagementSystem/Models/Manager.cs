public class Manager : Employee
{
    public double Allowance { get; set; }

    public Manager(int id,
                   string name,
                   double salary,
                   double allowance)
        : base(id, name, salary)
    {
        Allowance = allowance;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + Allowance;
    }

    public override void Display()
    {
        Console.WriteLine("Manager");

        base.Display();

        Console.WriteLine($"Allowance : {Allowance}");
    }
}