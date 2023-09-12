// See https://aka.ms/new-console-template for more information

using C__Övning_1;
class Program
{
    static void Main()
    {
        PersonnelRegister register = new PersonnelRegister();

        while (true)
        {
            Console.WriteLine("1. Add New Employee");
            Console.WriteLine("2. Display Employees");
            Console.WriteLine("3. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Salary: ");
                    double salary = double.Parse(Console.ReadLine());

                    Employee newEmployee = new Employee { Name = name, Salary = salary };
                    register.AddEmployee(newEmployee);
                    break;
                case 2:
                    register.DisplayEmployees();
                    break;
                case 3:
                    return;
                default:
                    break;
            }
        }
    }
}

