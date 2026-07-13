EmployeeService service = new EmployeeService();

while (true)
{
    Console.WriteLine("\nEmployee Management System");
    Console.WriteLine("1. Add Developer");
    Console.WriteLine("2. Add Manager");
    Console.WriteLine("3. View");
    Console.WriteLine("4. Search");
    Console.WriteLine("5. Update");
    Console.WriteLine("6. Delete");
    Console.WriteLine("7. Exit");

    Console.Write("Choice: ");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:

            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Bonus: ");
            double bonus = Convert.ToDouble(Console.ReadLine());

            service.AddEmployee(
                new Developer(id, name, salary, bonus));

            break;

        case 2:

            Console.Write("Id: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Allowance: ");
            double allowance = Convert.ToDouble(Console.ReadLine());

            service.AddEmployee(
                new Manager(id, name, salary, allowance));

            break;

        case 3:

            service.ViewEmployees();

            break;

        case 4:

            Console.Write("Enter ID: ");

            service.SearchEmployee(
                Convert.ToInt32(Console.ReadLine()));

            break;

        case 5:

            Console.Write("Enter ID: ");

            service.UpdateEmployee(
                Convert.ToInt32(Console.ReadLine()));

            break;

        case 6:

            Console.Write("Enter ID: ");

            service.DeleteEmployee(
                Convert.ToInt32(Console.ReadLine()));

            break;

        case 7:

            return;
    }
}