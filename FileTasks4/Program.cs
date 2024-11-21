using System;

class Program
{
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
    }

    static void Task1()
    {
        // Задание 1. Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,
        // которые нужно поменять местами. Вывести на экран получившийся массив.
        Console.WriteLine("Задание 1");
        Random random = new Random();
        int[] array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 500);
        }

        Console.WriteLine("Сгенерированный массив из 20 случайных чисел:");
        PrintArray(array);
        Console.WriteLine("Введите индексы двух чисел для обмена: ");
        Console.Write("Первый индекс: ");
        int index1 = int.Parse(Console.ReadLine());
        Console.Write("Второй индекс: ");
        int index2 = int.Parse(Console.ReadLine());

        if (index1 >= 0 && index1 < array.Length && index2 >= 0 && index2 < array.Length)
        {
            Swap(array, index1, index2);
            Console.WriteLine("Массив после обмена элементов:");
            PrintArray(array);
        }
        else
        {
            Console.WriteLine("Некорректные индексы. Пожалуйста, введите индексы от 1 до 19.");
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static void Swap(int[] array, int index1, int index2)
    {
        (array[index1], array[index2]) = (array[index2], array[index1]);
    }

    static void Task2()
    {
        // Задание 2. Написать метод, где в качества аргумента будет передан массив (ключевое слово
        // params). Вывести сумму элементов массива (вернуть). Вывести (ref) произведение
        // массива. Вывести (out) среднее арифметическое в массиве.
        Console.WriteLine("Задание 2");
        int[] numbers = { 5, 8, 9, 19, 24 };
        int product = 1;
        double average;
        int sum = CalculateArrayStatistics(numbers, ref product, out average);

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Произведение: {product}");
        Console.WriteLine($"Среднее арифметическое: {average}");
    }

    public static int CalculateArrayStatistics(int[] array, ref int product, out double average)
    {
        int sum = 0;
        product = 1;

        foreach (int number in array)
        {
            sum += number;
            product *= number;
        }

        average = (double)sum / array.Length;
        return sum;
    }

    public static void PrintNumbers(params int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }

    static void Task3()
    {
        // Задание 3. Пользователь вводит числа. Если числа от 0 до 9, то необходимо в консоли нарисовать
        // изображение цифры в виде символа #.Если число больше 9 или меньше 0, то консоль
        // должна окраситься в красный цвет на 3 секунды и вывести сообщение об ошибке. Если
        // пользователь ввёл не цифру, то программа должна выпасть в исключение. Программа
        // завершает работу, если пользователь введёт слово: exit или закрыть (оба варианта
        // должны сработать) - консоль закроется.
        Console.WriteLine("Задание 3");
        while (true)
        {
            Console.WriteLine("Введите число от 0 до 9 или слово 'exit'/'закрыть' для выхода:");
            string bb = Console.ReadLine();

            if (bb.Equals("exit", StringComparison.OrdinalIgnoreCase) || bb.Equals("закрыть", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            try
            {
                int number = int.Parse(bb);

                if (number >= 0 && number <= 9)
                {
                    char hash = '#';

                    switch (number)
                    {
                        case 0:
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"{hash}   {hash}");
                            Console.WriteLine($"{hash}   {hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            break;
                        case 1:
                            Console.WriteLine($"  {hash}");
                            Console.WriteLine($"  {hash}");
                            Console.WriteLine($"  {hash}");
                            Console.WriteLine($"  {hash}");
                            break;
                        case 2:
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"    {hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"{hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            break;
                        case 3:
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"    {hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"    {hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            break;
                        case 4:
                            Console.WriteLine($"{hash}   {hash}");
                            Console.WriteLine($"{hash}   {hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"    {hash}");
                            Console.WriteLine($"    {hash}");
                            break;
                        case 5:
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"{hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"    {hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            break;
                        case 6:
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"{hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"{hash}   {hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            break;
                        case 7:
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"    {hash}");
                            Console.WriteLine($"    {hash}");
                            Console.WriteLine($"    {hash}");
                            break;
                        case 8:
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"{hash}   {hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"{hash}   {hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            break;
                        case 9:
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"{hash}   {hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            Console.WriteLine($"    {hash}");
                            Console.WriteLine($"{hash}{hash}{hash}");
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка: Число должно быть от 0 до 9.");
                    System.Threading.Thread.Sleep(3000); 
                    Console.ResetColor(); 
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено не число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введено слишком большое число.");
            }
            Console.WriteLine();
        }
    }
    
    // Задание 4. Создать структуру Дед. У деда есть имя, уровень ворчливости (перечисление), массив
    // фраз для ворчания (прим.: “Проститутки!”, “Гады!”), количество синяков от ударов
    // бабки = 0 по умолчанию. Создать 5 дедов. У каждого деда - разное количество фраз для
    // ворчания. Напишите метод (внутри структуры), который на вход принимает деда,
    // список матерных слов (params). Если дед содержит в своей лексике матерные слова из
    // списка, то бабка ставит фингал за каждое слово. Вернуть количество фингалов.
    public enum LevelOfGrumpiness 
    {
        Low,
        Medium,
        High
    }
    static void Task4() 
    {
        Ded[] grandfather = new Ded[5]; 

        grandfather[0] = new Ded
        {
            Name = "Дед Ефросим",
            GrumpinessLevel = LevelOfGrumpiness.Medium,
            Complaints = new string[] { "Гады!", "Брысь отсюда!" },
            Bruises = 0
        };
        grandfather[1] = new Ded
        {
            Name = "Дед Геннадий",
            GrumpinessLevel = LevelOfGrumpiness.High,
            Complaints = new string[] { "Проститутки!", "Черти!" },
            Bruises = 0
        };
        grandfather[2] = new Ded
        {
            Name = "Дед Мефодий",
            GrumpinessLevel = LevelOfGrumpiness.High,
            Complaints = new string[] { "Черти!", "Гады!" },
            Bruises = 0
        };
        grandfather[3] = new Ded
        {
            Name = "Дед Григорий",
            GrumpinessLevel = LevelOfGrumpiness.Low,
            Complaints = new string[] { "Ай-яй-яй", "Совсем опешили!" },
            Bruises = 0
        };
        grandfather[4] = new Ded
        {
            Name = "Дед Петр",
            GrumpinessLevel = LevelOfGrumpiness.Medium,
            Complaints = new string[] { "Черти!", "Пошли вон!" },
            Bruises = 0
        };
        
        string[] swearWords = new string[] { "Проститутки", "Гады", "Суки", "Черти", "Срам" };

            
        foreach (var grandfather1 in grandfather)
        {
            int bruises = grandfather1.CheckForSwearWords(swearWords);
            Console.WriteLine($"{grandfather1.Name} получил {bruises} фингалов за матерные слова.");
            Console.ReadKey();
        }
    }
    public struct Ded 
    {
        public string Name;
        public LevelOfGrumpiness GrumpinessLevel;
        public string[] Complaints;
        public int Bruises;

        public int CheckForSwearWords(string[] swearWords)
        {
            int bruisesFromGrandma = 0;

            foreach (string complaint in Complaints)
            {
                foreach (string swearWord in swearWords)
                {
                    if (complaint.Contains(swearWord, StringComparison.OrdinalIgnoreCase))
                    {
                        bruisesFromGrandma++; 
                    }
                }
            }
            Bruises += bruisesFromGrandma;
            return bruisesFromGrandma; 
        }
    }
}



    