 class Employee
{
    public string Name;
    public int Age;

    // Default Constructor
    public Employee()
    {
        Name = "John Doe";
        Age = 30;
    }

    // Parameterized Constructor
    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an object using default constructor
        Employee emp1 = new Employee();
        Console.WriteLine("Employee details with default constructor:");
        emp1.DisplayDetails();

        // Creating an object using parameterized constructor
        Employee emp2 = new Employee("Alice", 25);
        Console.WriteLine("\nEmployee details with parameterized constructor:");
        emp2.DisplayDetails();
    }
}