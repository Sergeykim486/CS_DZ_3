// =========================== общие функции ===========================

int choice = 1;
int CurrentLine = 1;
string ex = "n";
string[] ListMenu = {
"  Задача 19: Является ли число полиндромом?                       ",
"  Задача 21: Расстояние между 2 точами (3D)                       ",
"  Задача 23: Возвести числа от 1 до N в куб                       ",
"  Задача 21*: Расстояние между 2 точками в N-мерном пространстве  ",
"  ВЫХОД ИЗ ПРОГРАММЫ                                              "};
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;

// ОТРИСОВКА МЕНЮ
void menu()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine(choice);
    int i = 0;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("═══════════════════  Г Л А В Н О Е   М Е Н Ю  ════════════════════\n");
    Console.ForegroundColor = ConsoleColor.White;
    while (i < ListMenu.Length)
    {
        CurrentLine = i + 1;
        if (choice == CurrentLine)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write($"{ListMenu[i]}\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write($"{ListMenu[i]}\n");
        }
        i++;
    }
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("\n" +
    "╔════════════════════════════════════════════════╤═══════════════╗\n" +
    "║  Используйте [стрелки] для навигации.          │   ▲ : Вверх   ║\n" +
    "║  [ENTER] - Выбор выделенного пункта            │   ▼ : Вниз    ║\n" +
    "╚════════════════════════════════════════════════╧═══════════════╝\n");
    Console.BackgroundColor = ConsoleColor.Black;
}

// ВВОД ЧИСЛА
int GetData()
{
    Console.Write("\n_______________________________________________\n" +
    "Введите целое число... ");
    int result1 = Convert.ToInt32(Console.ReadLine());
    return result1;
}


void restartP()
{
    try
    {
        main();
    }
    catch
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ОШИБКА!\n" +
        "Неверный ввод данных.\n" +
        "Программа будет перезапущена.");
        Console.ForegroundColor = ConsoleColor.White;
        pause();
    }
}

// ПАУЗА ДЛЯ ЧТЕНИЯ ВЫВОДИМЫХ ДАННЫХ
void pause()
{
    Console.WriteLine("Для продолжения нажмите любую клавишу...");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    try
    {
        main();
    }
    catch
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("ОШИБКА!\n" +
        "Неверный ввод данных.\n" +
        "Программа будет перезапущена.");
        Console.ForegroundColor = ConsoleColor.White;
        restartP();
    }
}

// ВЫХОД ИЗ ПРОГРАММЫ
void ext()
{
    Console.Clear();
AskAgayn:
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n" +
    "  ╔═════════════════════════════════════════════════════╗\n" +
    "  ║      Вы уверены что хотите закрыть программу?       ║\n" +
    "  ║              [ENTER] Да     [ESC] Нет               ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    Console.ForegroundColor = ConsoleColor.White;
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("ОШИБКА!\n" +
        "Вы нажали не ту клавишу." +
        "Нажмите [ENTER] или [ESC].");
        Console.ForegroundColor = ConsoleColor.White;
        goto AskAgayn;
    }
    else if (key.Key == ConsoleKey.Escape) main();
    else if (key.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        System.Environment.Exit(0);
    }
    else main();
}

// ==========================================================================



// =========================== Домашнее задание ===========================

// 1 ЗАДАЧА //
int palindrom(int num)
{
    int res = 0;
    int num2 = num;
    int Back = 0;
    int i = 0;
    while (num2 > 0)
    {
        i = num2 % 10;
        Back = Back * 10 + i;
        num2 = num2 / 10;
    }
    if (Back == num) res = 1;
    else res = 0;
    return (res);
}

// 2 ЗАДАЧА //
double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2);
    dist = Math.Sqrt(dist);
    return (dist);
}

// 3 ЗАДАЧА //
int[] Cube(int N)
{
    int[] array = new int[N];
    int i = 0;
    while (i < N)
    {
        int num = i + 1;
        array[i] = num * num * num;
        i++;
    }
    return (array);
}

// 4 ЗАДАЧА

double DistanceN(int nn, int[] a, int[] b)
{
    int i = 0;
    double sum = 0;
    while (i < nn)
    {
        sum = sum + (a[i] - b[i]) * (a[i] - b[i]);
        i++;
    }
    sum = Math.Sqrt(sum);
    return (sum);
}

// ==========================================================================



// =========================== Обработка выбора в меню ===========================

// ВЫПОЛНЕНИЕ ПРОГРАММЫ И ОТСЛЕЖИВАНИЕ НАЖАТИЯ КЛАВИШ
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
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\n" +
                    "Введите число для проверки...");
                    int x = Convert.ToInt32(GetData());
                    int y = palindrom(x);
                    if (y == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n" +
                        "  ╔═══════════════════════════════════╗\n" +
                        $"      ВВЕДЕННОЕ ЧИСЛО {x}\n" +
                        "      ЯВЛЯЕТСЯ ПАЛИНДРОМОМ\n" +
                        "  ╚═══════════════════════════════════╝\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n" +
                        "  ╔═══════════════════════════════════╗\n" +
                        $"      ВВЕДЕННОЕ ЧИСЛО {x}\n" +
                        "      НЕ ЯВЛЯЕТСЯ ПАЛИНДРОМОМ\n" +
                        "  ╚═══════════════════════════════════╝\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    pause();
                    goto restart;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("_______________________________________________\n" +
                    "координаты первой точки \nX1 = ");
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Y1 = ");
                    int y1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Z1 = ");
                    int z1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("_______________________________________________\n" +
                    "координаты второй точки \nX2 = ");
                    int x2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Y2 = ");
                    int y2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Z2 = ");
                    int z2 = Convert.ToInt32(Console.ReadLine());
                    double Distance = Distance3D(x1, y1, z1, x2, y2, z2);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n" +
                    "  ╔════════════════════════════════════════╗\n" +
                    $"      РАССТОЯНИЕ ОТ ТОЧКИ ({x1}, {y1}, {z1})\n" +
                    $"      ДО ТОЧКИ ({x2}, {y2}, {z2})\n" +
                    $"      СОСТАВЛЯЕТ - {Distance}\n" +
                    "  ╚════════════════════════════════════════╝\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    pause();
                    goto restart;
                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Введите число [N]...");
                    int Cub = GetData();
                    int[] res = Cube(Cub);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n  ╔══════════════════════════════════╗");
                    int i = 0;
                    while (i < Cub)
                    {
                        int ln = i + 1;
                        int number = res[i];
                        Console.WriteLine($"    {ln}-е число ({ln}) в кубе = {number}");
                        i++;
                    }
                    Console.WriteLine("  ╚══════════════════════════════════╝\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    pause();
                    goto restart;
                case 4:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Введите число [N]...");
                    int nn = GetData();
                    int[] a = new int[nn];
                    int[] b = new int[nn];
                    int ii = 0;
                    int point = 1;
                    int cur = 0;
                    while (ii < nn)
                    {
                        if (ii == 0)
                        {
                            if (point == 1)
                            {
                                Console.Write("_______________________________________________\n" +
                                $"Введите координаты точки [A] \n");
                            }
                            else
                            {
                                Console.Write("_______________________________________________\n" +
                                $"Введите координаты точки [B] \n");
                            }
                        }
                        cur = nn - 1;
                        int np = ii + 1;
                        if (point == 1)
                        {
                            if (ii <= cur)
                            {
                                Console.Write($"Введите координаты по оси {np} = ");
                                a[ii] = Convert.ToInt32(Console.ReadLine());
                                ii++;
                                if (ii > cur)
                                {
                                    point = 2;
                                    ii = 0;
                                }
                            }
                        }
                        else
                        {
                            Console.Write($"Введите координаты по оси {np} = ");
                            b[ii] = Convert.ToInt32(Console.ReadLine());
                            ii++;
                        }
                    }
                    double distance = DistanceN(nn, a, b);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n" +
                    "  ╔════════════════════════════════════════╗\n" +
                    $"      РАССТОЯНИЕ МЕЖДУ ТОЧКАМИ В N-МЕРНОМ\n" +
                    $"      ПРОСТРАНСТВЕ (где N = {nn})\n" +
                    $"      СОСТАВЛЯЕТ - {distance}\n" +
                    "  ╚════════════════════════════════════════╝\n");
                    Console.ForegroundColor = ConsoleColor.White;
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

// ==========================================================================



// =========================== Обработка выбора в меню ===========================

try
{
    main();
}

catch
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("ОШИБКА!\n" +
    "Неверный ввод данных.\n" +
    "Программа будет перезапущена.");
    Console.ForegroundColor = ConsoleColor.White;
    pause();
}