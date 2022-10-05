using System;

public class Class_1
{
    public static void Main(string[] args)
    {

        int a, b;
        Console.WriteLine("Give two numbers, a and b to add: ");
        Console.Write("a = ");
        // a = int.Parse(Console.ReadLine());
        a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine($"a + b = {a+b}");
        Console.ReadKey();
        Console.Clear();
        Console.Write("Table height: ");
        int int_height = int.Parse(Console.ReadLine());
        TablelDraw(int_height, ConsoleColor.Red, ConsoleColor.Blue);
        Console.WriteLine();
        TablelDraw(int_height, ConsoleColor.Blue, ConsoleColor.Red);
        Console.WriteLine("This is the end...");
        Console.ReadKey();
    }

    static void TablelDraw(int height, ConsoleColor color, ConsoleColor back_color)
    {
        ConsoleColor foreground, background;
        foreground = Console.ForegroundColor;
        background = Console.BackgroundColor;

        Console.ForegroundColor = color;
        Console.BackgroundColor = back_color;
        Console.WriteLine("****************************");
        for (int i = 0; i < height; i++)
        {
            Console.WriteLine("*                          *");
        }
        Console.WriteLine("****************************");

        Console.ReadKey();

        Console.ForegroundColor = foreground;
        Console.BackgroundColor = background;
    }
}
