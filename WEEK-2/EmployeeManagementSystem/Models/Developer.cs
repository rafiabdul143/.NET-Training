public class Developer : Employee
{
    public double Bonus { get; set; }

    public Developer(int id, string name,
                     double salary,
                     double bonus)
        : base(id, name, salary)
    {
        Bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + Bonus;
    }

    public override void Display()
    {
        Console.WriteLine("Developer");

        base.Display();

        Console.WriteLine($"Bonus : {Bonus}");
    }
}