using System;
do
{
    Console.WriteLine("1-Игра Угадай число.");
    Console.WriteLine("2-Таблица умножения.");
    Console.WriteLine("3-Вывод делителей числа.");
    Console.WriteLine("4-Выход.");
    Console.Write("Введите число:");
    string i = Console.ReadLine();
    int j = Convert.ToInt32(i);
    if (j == 1)
    {
        Console.WriteLine("Вы выбрали число 1:(Игра Угадай число).");
        Console.Write("Угадайте число от 0 до 100:");
        Random random = new Random();
        int k = random.Next(100);
        //Console.WriteLine(k)
        while (true)
        {
            string r = Console.ReadLine();
            int y = Convert.ToInt32(r);
            if (y == k)
            {
                Console.WriteLine("Угадал.Поздравляю.");
                break;
            }
            if (y > k)
            {
                Console.WriteLine("Не угадал. Число должно быть меньше.");
            }
            if (y < k)
            {
                Console.WriteLine("Не угадал. Число должно быть больше.");
            }
        }
    }
    if (j == 2)
    {
        Console.WriteLine("Вы выбрали число 2:(Таблица умножения).");
        int[,] r = new int[9,9];
        for(int x=1; x<=9; x++)
        {
            for(int y=1; y<=9; y++)
            {
                Console.Write((y*x)+"\t");
            } 
            Console.WriteLine();
        }
    }
    if (j == 3)
    {
        Console.WriteLine("Вы выбрали число 3:(Вывод делителей числа).");
        Console.Write("Введите число:");
        string n = Console.ReadLine();
        int m = Convert.ToInt32(n);
        Console.Write("Делители: ");
        for (int c = 1; c <= m; c++)
        {
            if (m % c == 0)
            Console.Write("{0}",c+"\t");
        }
        Console.WriteLine("");
    }
    if (j == 4)
    {
        Console.WriteLine("Программа завершена.");
        break;
    }
    else
    {
        Console.WriteLine("Введенно неправильное число.");
    }
}
while (true);