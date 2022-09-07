int choice = 1;
int CurrentLine = 1;
string ex = "n";

string[] ListMenu = {
"1 menu line",
"2 menu line",
"3 menu line",
"4 menu line",
"ВЫХОД ИЗ ПРОГРАММЫ"
};
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;

void menu()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine(choice);
    int i = 0;
    Console.Clear();
    while (i < ListMenu.Length)
    {
        CurrentLine = i + 1;
        if (choice == CurrentLine)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"{ListMenu[i]}\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write($"{ListMenu[i]}\n");
        }
        i++;
    }
}

void pause()
{
    Console.WriteLine("Для продолжения нажмите любую клавишу...");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    menu();
}

void ext()
{
    Console.Clear();
AskAgayn:
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n=========================================================\n" +
    "    Вы уверены что хотите закрыть программу?\n" +
    "    Клавиша [ y ] - Да\n" +
    "    Клавиша [ n ] - Нет" +
    "\n=========================================================\n");
    Console.ForegroundColor = ConsoleColor.White;
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    // ex = Convert.ToString(Console.ReadLine());
    if (key.Key != ConsoleKey.Y && key.Key != ConsoleKey.N)
    {
        Console.Clear();
        Console.WriteLine("Вы нажали не ту клавишу!");
        goto AskAgayn;
    }
    else if (key.Key == ConsoleKey.N) main();
    else if (key.Key == ConsoleKey.Y) System.Environment.Exit(0);
    else main();
}


// ==========================================================================


void main()
{
    if (ex.ToLower() == "n")
    {
    restart:
        menu();
        ConsoleKeyInfo key;
        key = Console.ReadKey();
        if (key.Key == ConsoleKey.UpArrow)
        {
            if (choice <= ListMenu.Length)
            {
                if (choice == 1)
                {
                    choice = ListMenu.Length;
                    goto restart;
                }
                else
                {
                    choice = choice - 1;
                    goto restart;
                }
            }
            else goto restart;
        }
        else if (key.Key == ConsoleKey.DownArrow)
        {
            if (choice >= 1)
            {
                if (choice == ListMenu.Length)
                {
                    choice = 1;
                    goto restart;
                }
                else
                {
                    choice = choice + 1;
                    goto restart;
                }
            }
            else goto restart;
        }
        else if (key.Key == ConsoleKey.Enter)
        {
            switch (choice)
            {
                case 1:
                    pause();
                    goto restart;
                case 2:
                    pause();
                    goto restart;
                case 3:
                    pause();
                    goto restart;
                case 4:
                    pause();
                    goto restart;
                case 5:
                    ext();
                    goto restart;
            }
        }
        else goto restart;
    }
}

main();