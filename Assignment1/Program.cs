public class Employee
{
    private int Id;
    private string Name;
    private string DepartmentName;

    // Event declaration
    public event EventHandler<string> MethodCalled;

    public Employee(int id, string name, string departmentName)
    {
        Id = id;
        Name = name;
        DepartmentName = departmentName;
    }

    // Methods to get properties
    public int GetId()
    {
        OnMethodCalled(nameof(GetId)); 
        return Id;
    }

    public string GetName()
    {
        OnMethodCalled(nameof(GetName)); 
        return Name;
    }

    public string GetDepartmentName()
    {
        OnMethodCalled(nameof(GetDepartmentName)); 
        return DepartmentName;
    }

    // Overloaded methods to update properties
    public void UpdateId(int newId)
    {
        Id = newId;
    }

    public void UpdateName(string newName)
    {
        Name = newName;
    }

    public void UpdateDepartmentName(string newDepartmentName)
    {
        DepartmentName = newDepartmentName;
    }

    // Method to invoke event with method name
    private void OnMethodCalled(string methodName)
    {
        MethodCalled?.Invoke(this, methodName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter employee details:");
        Console.Write("Id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Department Name: ");
        string departmentName = Console.ReadLine();

        Employee emp = new Employee(id, name, departmentName);

        // Event handler
        emp.MethodCalled += (sender, methodName) => Console.WriteLine($"\n{methodName}() method called.");

        Console.WriteLine("\nEmployee details:");
        Console.WriteLine("Id: " + emp.GetId());
        Console.WriteLine("Name: " + emp.GetName());
        Console.WriteLine("Department Name: " + emp.GetDepartmentName());

        // Update employee details
        Console.WriteLine("\nEnter new details:");
        Console.Write("New Id: ");
        emp.UpdateId(Convert.ToInt32(Console.ReadLine()));
        Console.Write("New Name: ");
        emp.UpdateName(Console.ReadLine());
        Console.Write("New Department Name: ");
        emp.UpdateDepartmentName(Console.ReadLine());

        Console.WriteLine("\nUpdated Employee details:");
        Console.WriteLine("Id: " + emp.GetId());
        Console.WriteLine("Name: " + emp.GetName());
        Console.WriteLine("Department Name: " + emp.GetDepartmentName());
    }
}