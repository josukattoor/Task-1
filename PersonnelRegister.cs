using C__Övning_1;
class PersonnelRegister
{
    private List<Employee> Employees { get; set; }

    public PersonnelRegister()
    {
        Employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public void DisplayEmployees()
    {
        Console.WriteLine("Employee Register:");
        foreach (var employee in Employees)
        {
            Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
        }
    }
}