using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }

    // Method overloading
    public void Draw(int width, int height)
    {
        Console.WriteLine($"Drawing a rectangle with width {width} and height {height}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Shape();
        shape.Draw(); // Calls Draw() method of Shape class

        Circle circle = new Circle();
        circle.Draw(); // Calls Draw() method of Circle class

        Rectangle rectangle = new Rectangle();
        rectangle.Draw(); // Calls Draw() method of Rectangle class

        // Method overloading
        rectangle.Draw(10, 5); // Calls overloaded Draw() method of Rectangle class
    }
}