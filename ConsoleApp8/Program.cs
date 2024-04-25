using System;

class Car
{
    // Fields
    private string model;
    private int year;
    private string manufacturer;

    // Constructor
    public Car(string model, int year, string manufacturer)
    {
        this.model = model;
        this.year = year;
        this.manufacturer = manufacturer;
    }

    // Method to set the car's model
    public void SetModel(string model)
    {
        this.model = model;
    }

    // Method to get the car's model
    public string GetModel()
    {
        return model;
    }

    // Method to set the car's year
    public void SetYear(int year)
    {
        this.year = year;
    }

    // Method to get the car's year
    public int GetYear()
    {
        return year;
    }

    // Method to set the car's manufacturer
    public void SetManufacturer(string manufacturer)
    {
        this.manufacturer = manufacturer;
    }

    // Method to get the car's manufacturer
    public string GetManufacturer()
    {
        return manufacturer;
    }

    // Method to display all details of the car
    public void DisplayDetails()
    {
        Console.WriteLine($"Car Details:");
        Console.WriteLine($"Model: {model}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Manufacturer: {manufacturer}");
    }
}

class Program
{
    static void Main()
    {
        // Create a new car object
        Car myCar = new Car("Accord", 2022, "Honda");

        // Display initial car details
        myCar.DisplayDetails();

        // Update car details
        myCar.SetModel("Civic");
        myCar.SetYear(2023);
        myCar.SetManufacturer("Toyota");

        // Display updated car details
        myCar.DisplayDetails();
    }
}