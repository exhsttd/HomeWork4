using System;

class Program 
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
    }
    static void Task1()
    {
        // Упражнение 5.1 Написать метод, возвращающий наибольшее из двух чисел. Входные
        // параметры метода – два целых числа. Протестировать метод.
        Console.WriteLine("Упр 5.1");
        static int Max(int a, int b)
        { return a > b ? a : b; }
        Console.WriteLine("Тестирование метода Max:");
        int num1 = 3;
        int num2 = 6;
        int result1 = Max(num1, num2);
        Console.WriteLine($"Наибольшее из {num1} и {num2} = {result1}");

        num1 = 65;
        num2 = 54;
        int result2 = Max(num1, num2);
        Console.WriteLine($"Наибольшее из {num1} и {num2} = {result2}");

        num1 = 0;
        num2 = 0;
        int result3 = Max(num1, num2);
        Console.WriteLine($"Наибольшее из {num1} и {num2} = {result3}");

        num1 = -4;
        num2 = -1;
        int result4 = Max(num1, num2);
        Console.WriteLine($"Наибольшее из {num1} и {num2} = {result4}");
        Console.WriteLine();
    }
    
    static void Task2()
    {
        // Упражнение 5.2 Написать метод, который меняет местами значения двух передаваемых
        // параметров. Параметры передавать по ссылке. Протестировать метод.
        Console.WriteLine("Упр 5.2");
        static void Swap(ref int a, ref int b)
        {
            (a, b) = (b, a);
        }
        Console.WriteLine("Тестирование метода обмена:");
        int num11 = 10;
        int num21 = 20;

        Console.WriteLine($"До обмена: num1 = {num11}, num2 = {num21}");
        Swap(ref num11, ref num21);
        Console.WriteLine($"После обмена: num1 = {num11}, num2 = {num21}");   
        Console.WriteLine();
    }

    static void Task3()
    {
        // Упражнение 5.3 Написать метод вычисления факториала числа, результат вычислений 
        // передавать в выходном параметре. Если метод отработал успешно, то вернуть значение true;
        // если в процессе вычисления возникло переполнение, то вернуть значение false. Для
        // отслеживания переполнения значения использовать блок checked.
        Console.WriteLine("Упр 5.3");
        static bool TryFactorial(int n, out long result)
        {
            result = 1;
            try
            {
                checked
                {
                    for (int i = 1; i <= n; i++)
                    {
                        result *= i;
                    }
                }

                return true;
            }
            catch (OverflowException)
            {
                return false;
            }
        }
        Console.Write("Введите число для вычисления факториала: ");
        int number = int.Parse(Console.ReadLine());
        if (TryFactorial(number, out long factorial))
        {
            Console.WriteLine($"Факториал {number} = {factorial}");
        }
        else
        {
            Console.WriteLine($"Переполнение при вычислении факториала {number}.");
        }
        Console.WriteLine();
    }

    static void Task4()
    {
        // Упражнение 5.4 Написать рекурсивный метод вычисления факториала числа.
        Console.WriteLine("Упр 5.4");
        Console.Write("Введите число для вычисления факториала: ");
        int n = int.Parse(Console.ReadLine());
        
        if (n < 0)
        {
            Console.WriteLine("Факториал отрицательного числа не определен.");
        }
        else
        {
            int result = RecursiveFactorial(n);
            Console.WriteLine($"Факториал {n} равен {result}");
        }
        static int RecursiveFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * RecursiveFactorial(n - 1);
        }
        Console.WriteLine();
    }

    static void Task5()
    {
        // Домашнее задание 5.1 Написать метод, который вычисляет НОД двух натуральных чисел
        // (алгоритм Евклида). Написать метод с тем же именем, который вычисляет НОД трех
        // натуральных чисел.
        Console.WriteLine("ДЗ 5.1");
        Console.Write("Введите первое число: ");
        uint a = uint.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        uint b = uint.Parse(Console.ReadLine());

        uint gcdTwo = Gcd(a, b);
        Console.WriteLine($"НОД чисел {a} и {b} равен {gcdTwo}.");

        Console.Write("Введите третье число: ");
        uint c = uint.Parse(Console.ReadLine());
        uint gcdThree = Gcd(a, b, c);
        Console.WriteLine($"НОД чисел {a}, {b} и {c} равен {gcdThree}.");
        Console.WriteLine();
    }
    static uint Gcd(uint a, uint b)
    {
        while (b != 0)
        {
            uint temp = b;
            b = a % b;
            a = temp;
        }
        return a; 
    }

    static uint Gcd(uint a, uint b, uint c)
    {
        return Gcd(Gcd(a, b), c);
    }
    

    static void Task6()
    {
        // Домашнее задание 5.2 Написать рекурсивный метод, вычисляющий значение n-го числа
        // ряда Фибоначчи. Ряд Фибоначчи – последовательность натуральных чисел 1, 1, 2, 3, 5, 8,
        // 13... Для таких чисел верно соотношение Fk = Fk-1 + Fk-2.
        Console.WriteLine("ДЗ 5.2");
        Console.Write("Введите номер числа Фибоначчи (n): ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Введите натуральное число (1 или больше)");
        }
        else
        {
            int result = Fibonacci(n);
            Console.WriteLine($"Число Фибоначчи под номером {n} равно {result}");
        }
        static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        Console.WriteLine();
    }
}

   
