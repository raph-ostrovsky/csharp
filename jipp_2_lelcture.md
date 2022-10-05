Menu.cs

```cs
using System;

namespace Klasy
{
    class Menu
    {
        string[] data;
        // gives colors to memu
        ConsoleColor choice_color=ConsoleColor.DarkBlue, background_color=ConsoleColor.Blue;

        public void UstawDane(string[] danedoWyswietlenia)
        {
            if (danedoWyswietlenia.Length < 20)
            {
                data = danedoWyswietlenia;
            }
        }

        public int Wyswietl()
        {
            Console.CursorVisible = false;
            int choice = 0;
            // finds the longest string in the menu
            int width = 0;
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            int beggining = Console.CursorTop;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].Length > width)
                    width = data[i].Length;
            
            }
            // loop waiting for enter
            do
            {
                for (int i = 0; i < data.Length; i++)
                {

                    // gives another color to the choice 
                    if (i == choice)
                    {
                        Console.BackgroundColor = choice_color;
                    }
                    else
                    {
                        Console.BackgroundColor = background_color;
                    }
                    Console.WriteLine(data[i].PadRight(width));
                }

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.UpArrow && choice > 0)
                    choice--;
                if (key.Key == ConsoleKey.DownArrow && choice < data.Length - 1)
                    choice++;
                Console.CursorTop = beggining;
                Console.CursorLeft = 0;
            } while (key.Key != ConsoleKey.Enter);

            return choice;
        }

    }


}
```

Program.cs

```cs
using System;
namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menuPlik = new Menu();
            menuPlik.UstawDane(new string[] { "Otworz", "Zapisz", "Zapisz jako...", "Wyjdz", "Dodatkowe"});

            int choice = menuPlik.Wyswietl();
            if (choice == 0)
            {
                string[] filedata = File.ReadAllLines("dane.txt");
                for (int i = 0; i < filedata.Length; i++)
                {
                    Console.WriteLine(filedata[i]);
                }
                Console.ReadKey();

            }
            if (choice == 3)
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Bye...");
                Console.ReadKey();
            }
        }

    }
}
```
