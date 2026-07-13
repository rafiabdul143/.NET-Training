/*ing System; // Fixed: Capitalized 'S'

// Renamed class to 'Program' to avoid conflicts with the Main method
public class Program 
{
    public static void Main(string[] args) // Fixed: Capitalized 'M' and lowercase 'string'
    {
        Developer developer = new Developer();
        developer.Name = "John Doe";
        developer.Salary = 80000m;
        
        // Let's actually call the methods to test them
        developer.Work();
        developer.Code();
    }
} // Fixed: Correctly closed the Program class here

// Base Class (Parent)
public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public void Work()
    {
        Console.WriteLine($"{Name} is working.");
    }
}

// Derived Class (Child)
public class Developer : Employee
{
    public string MainProgrammingLanguage { get; set; }

    public void Code()
    {
        Console.WriteLine($"{Name} is writing C# code.");
    }
}
*/using System;

public class Program 
{
    public static void Main(string[] args) 
    {
        Developer developer = new Developer();
        
        // Using explicit setter methods to assign values
        developer.SetName("John Doe");
        developer.SetSalary(80000m);
        developer.SetMainProgrammingLanguage("C#");
        
        developer.Work();
        developer.Code();
    }
}

// Base Class (Parent)
public class Employee
{
    // Private backing fields: Hidden from the outside world
    private string _name;
    private decimal _salary;

    // Getter and Setter for Name
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    // Getter and Setter for Salary
    public decimal GetSalary()
    {
        return _salary;
    }
    public void SetSalary(decimal salary)
    {
        _salary = salary;
    }

    public void Work()
    {
        // Using the internal private field directly
        Console.WriteLine($"{_name} is working.");
    }
}

// Derived Class (Child)
public class Developer : Employee
{
    // Private backing field unique to Developer
    private string _mainProgrammingLanguage;

    // Getter and Setter for MainProgrammingLanguage
    public string GetMainProgrammingLanguage()
    {
        return _mainProgrammingLanguage;
    }
    public void SetMainProgrammingLanguage(string language)
    {
        _mainProgrammingLanguage = language;
    }

    public void Code()
    {
        // Notice we must use GetName() here because _name is private to Employee!
        Console.WriteLine($"{GetName()} is writing {_mainProgrammingLanguage} code.");
    }
}
