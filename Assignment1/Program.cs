using System;

public class Employee
{
    private int Id;
    private string Name;
    private string DeptName;

    // Event declaration
    public event EventHandler MethodCalled;

    public Employee(int id, string name, string deptName)
    {
        Id = id;
        Name = name;
        DeptName = deptName;
    }

    // Methods to get properties
    public int GetId()
    {
        MethodCalled?.Invoke(this, EventArgs.Empty); // Invoke event
        return Id;
    }

    public string GetName()
    {
        MethodCalled?.Invoke(this, EventArgs.Empty); // Invoke event
        return Name;
    }

    public string GetDeptName()
    {
        MethodCalled?.Invoke(this, EventArgs.Empty); // Invoke event
        return DeptName;
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

    public void UpdateDeptName(string newDeptName)
    {
        DeptName = newDeptName;
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
        string deptName = Console.ReadLine();

        Employee emp = new Employee(id, name, deptName);

        // Event handler
        emp.MethodCalled += (sender, e) => Console.WriteLine("\nMethod called in Employee class.");

        Console.WriteLine("Employee details:");
        Console.WriteLine("Id: " + emp.GetId());
        Console.WriteLine("Name: " + emp.GetName());
        Console.WriteLine("Department Name: " + emp.GetDeptName());

        // Update employee details
        Console.WriteLine("\nEnter new details for updating:");
        Console.Write("New Id: ");
        emp.UpdateId(Convert.ToInt32(Console.ReadLine()));
        Console.Write("New Name: ");
        emp.UpdateName(Console.ReadLine());
        Console.Write("New Department Name: ");
        emp.UpdateDeptName(Console.ReadLine());

        Console.WriteLine("\nUpdated Employee details:");
        Console.WriteLine("Id: " + emp.GetId());
        Console.WriteLine("Name: " + emp.GetName());
        Console.WriteLine("Department Name: " + emp.GetDeptName());
    }
}