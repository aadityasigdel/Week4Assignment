using System;
using Week4assignment;
class Program
{

    static void Main(string[] args)
    {

        //Taks 1 :Class, Object & Fields

        //objects of Student
        Student s1 = new Student();
        Student s2 = new Student();

        // Assign values for student 1
        s1.name = "Ramesh";
        s1.age = 20;
        s1.course = "Computer Science";

        // Assign values for Student 2
        s2.name = "Aabishan";
        s2.age = 22;
        s2.course = "Mathematics";

        // Display field values
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Age: " + s1.age);
        Console.WriteLine("Course: " + s1.course);

        Console.WriteLine("\n");
        Console.WriteLine("Name: " + s2.name);
        Console.WriteLine("Age: " + s2.age);
        Console.WriteLine("Course: " + s2.course);

        // Print static field
        Console.WriteLine("\nSchool Name: " + Student.schoolName);


        //Taks 2 :Methods & Return Types

        Calculator calc = new Calculator();

        calc.PrintWelcome();

        int sum = calc.Add(10, 20);
        Console.WriteLine("Addition: " + sum);

        int product1 = calc.Multiply(5, 4);
        Console.WriteLine("Multiplication: " + product1);

        int product2 = calc.Multiply(7);
        Console.WriteLine("Multiplication : " + product2);

        //Task 3 : Parameter Types
        ParameterDemo demo = new ParameterDemo();

        // Using ref parameter
        int value = 5;
        demo.Increase(ref value);
        Console.WriteLine("\n");
        Console.WriteLine("Value after Increase(): " + value);

        // Using out parameter
        demo.GetFullName(out string fullName);
        Console.WriteLine("Full Name: " + fullName);

        // Using params parameter
        int total = demo.SumAll(10, 20, 30, 40);
        Console.WriteLine("Sum of all numbers: " + total);

        // Task 4 : Constructors

        // using default constructor
        Player p1 = new Player();

        // Assign values to p1
        p1.playerName = "Aaditya Sigdel";
        p1.level = 10;
        p1.health = 2250;

        // using parameterized constructor
        Player p2 = new Player("Rakesh", 7, 1500);


        Console.WriteLine("\n");
        Console.WriteLine("Name: " + p1.playerName);
        Console.WriteLine("Level: " + p1.level);
        Console.WriteLine("Health: " + p1.health);

        Console.WriteLine("\n");
        Console.WriteLine("Name: " + p2.playerName);
        Console.WriteLine("Level: " + p2.level);
        Console.WriteLine("Health: " + p2.health);

        // Task 5:Enums and Records
        Console.Write("Enter a day (Example: Sunday): ");
        string inputDay = Console.ReadLine().Trim().ToLower();

        DayType dayType;

        if (inputDay == "sunday" || inputDay == "saturday" || inputDay == "monday")
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }
        Console.WriteLine("\n");
        Console.WriteLine("It is: " + dayType);


        //Book object
        Book book1 = new Book("Web development ", "Aaditya Sigdel", 2000);

        // object using 'with' expression
        Book book2 = book1 with { title = "Advanced prgraming", price = 4000 };

        Console.WriteLine("\n");
        Console.WriteLine($"Title: {book1.title}");
        Console.WriteLine($"Author: {book1.author}");
        Console.WriteLine($"Price: {book1.price}");

        // Deconstructed object
        var (title2, author2, price2) = book2;

        Console.WriteLine("\n");
        Console.WriteLine($"Title: {title2}");
        Console.WriteLine($"Author: {author2}");
        Console.WriteLine($"Price: {price2}");

        //Task 6: 

        Debugging debugging = new Debugging();
        debugging.Calculate();
    }
}
