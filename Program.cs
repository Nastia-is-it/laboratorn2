using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
namespace Lab2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            InputChecks inputChecks = new InputChecks();
            int a;
            string inputA;
            Console.WriteLine("1. Создать три точки с разными координатами");
            Console.WriteLine("2. Создать имена");
            Console.WriteLine("3. Создать линии");
            Console.WriteLine("4. Создать города и связи");
            Console.WriteLine("5. Создать дробь и выполнить действия с ней");
            while (true)
            {
                inputA = Console.ReadLine();
                if (!inputChecks.ToNumbers(inputA))
                {
                    Console.WriteLine("Некорректный ввод. Введите число от 1 до 5:");
                    continue;
                }
                a = Convert.ToInt32(inputA);
                if ((a < 1) || (a > 5))
                {
                    Console.WriteLine("Нет такого варианта выбора. Введите число от 1 до 5:");
                    continue;
                }
                break;
            }
            
            switch (a)
            {
                case 1:
                    int x, y;
                    for (int i = 1; i <= 3; i++)
                    {
                        while (true)
                        {
                            Console.WriteLine("Введите координаты " + i + " точки: ");                        
                            string inputX, inputY;
                            inputX = Console.ReadLine();
                            inputY = Console.ReadLine();
                            if (!inputChecks.ToNumbers(inputX) || !inputChecks.ToNumbers(inputY))
                            {
                                Console.WriteLine("Ошибка ввода. Введите числа");
                                continue;
                            }
                            x = Convert.ToInt32(inputX);
                            y = Convert.ToInt32(inputY);
                            break;
                        }
                        Dots dot = new Dots(x, y);
                        dot.Print();
                        Console.WriteLine("Создалась точка с координатами: " + dot.ToString());
                    }
                    break;

                case 2:
                    Names name1 = new Names("Клеопатра");
                    Names name2 = new Names("Пушкин", "Александр", "Сергеевич");
                    Names name3 = new Names("Маяковский", "Владимир");
                    Console.WriteLine(name1.ToString());
                    Console.WriteLine(name2.ToString());
                    Console.WriteLine(name3.ToString());
                    break;

                case 3:
                    Console.WriteLine("Линия 1 с началом в т. {1;3} и концом в т.{23;8}:");
                    Lines line1 = new Lines(1, 3, 23, 8);
                    Console.WriteLine(line1.ToString());
                    Console.WriteLine("Линия 2, горизонтальная, на высоте 10, от точки 5 до точки 25:");
                    Lines line2 = new Lines(5, 10, 25, 10);
                    Console.WriteLine(line2.ToString());
                    Console.WriteLine("Линия 3: Координаты начала совпадают с началом первой линии, а конца с концом второй:");                   
                    Lines line3 = new Lines(line1.Start, line2.End);
                    Console.WriteLine(line3.ToString());
                    Console.WriteLine("Изменить линии 1 и 2 (чтобы 3 линия соответствовала условиям пункта 3): ");
                    int x1, y1, x2, y2;
                    Console.WriteLine("Первая линия");
                    Console.WriteLine("Координаты первой точки");
                    while (true)
                    {
                        string inputX, inputY;
                        inputX = Console.ReadLine();
                        inputY = Console.ReadLine();
                        if (!inputChecks.ToNumbers(inputX) || !inputChecks.ToNumbers(inputY))
                        {
                            Console.WriteLine("Ошибка ввода. Введите числа");
                            continue;
                        }
                        x1 = Convert.ToInt32(inputX);
                        y1 = Convert.ToInt32(inputY);
                        break;
                    }
                    Console.WriteLine("Координаты второй точки");
                    while (true)
                    {
                        string inputX, inputY;
                        inputX = Console.ReadLine();
                        inputY = Console.ReadLine();
                        if (!inputChecks.ToNumbers(inputX) || !inputChecks.ToNumbers(inputY))
                        {
                            Console.WriteLine("Ошибка ввода. Введите числа");
                            continue;
                        }
                        x2 = Convert.ToInt32(inputX);
                        y2 = Convert.ToInt32(inputY);
                        break;
                    }
                    int a1, b1, a2, b2;
                    Console.WriteLine("Вторая линия");
                    Console.WriteLine("Координаты первой точки");
                    while (true)
                    {
                        string inputX, inputY;
                        inputX = Console.ReadLine();
                        inputY = Console.ReadLine();
                        if (!inputChecks.ToNumbers(inputX) || !inputChecks.ToNumbers(inputY))
                        {
                            Console.WriteLine("Ошибка ввода. Введите числа");
                            continue;
                        }
                        a1 = Convert.ToInt32(inputX);
                        b1 = Convert.ToInt32(inputY);
                        break;
                    }
                    Console.WriteLine("Координаты второй точки");
                    while (true)
                    {
                        string inputX, inputY;
                        inputX = Console.ReadLine();
                        inputY = Console.ReadLine();
                        if (!inputChecks.ToNumbers(inputX) || !inputChecks.ToNumbers(inputY))
                        {
                            Console.WriteLine("Ошибка ввода. Введите числа");
                            continue;
                        }
                        a2 = Convert.ToInt32(inputX);
                        b2 = Convert.ToInt32(inputY);
                        break;
                    }
                    line1.SetStart(x1, y1);
                    line1.SetEnd(x2, y2);
                    line2.SetStart(a1, b1);
                    line2.SetEnd(a2, b2);
                    Console.Write("Изменённая линия 3: ");
                    Console.WriteLine(line3.ToString());
                    Console.WriteLine("Меняю координаты первой линии, чтобы не менялась третяя: ");
                    Console.WriteLine("Тогда надо менять координаты второй точки у первой линии");
                    Console.WriteLine("Меняю эту точку на {20, 20}:");
                    line1.SetEnd(20, 20);
                    Console.WriteLine("Теперь это: " + line1.ToString());
                    Console.WriteLine("Линия 3 не изменилась:");
                    Console.WriteLine(line3.ToString());
                    break;

                case 4:
                    //простое создание городов
                    Cities cityA = new Cities("A");
                    Cities cityB = new Cities("B");
                    Cities cityC = new Cities("C");
                    Cities cityD = new Cities("D");
                    Cities cityE = new Cities("E");
                    Cities cityF = new Cities("F");

                    cityA.Connection("B", 5);
                    cityA.Connection("F", 1);
                    cityA.Connection("D", 6);

                    cityB.Connection("A", 5);
                    cityB.Connection("C", 3);

                    cityC.Connection("B", 3);
                    cityC.Connection("D", 4);

                    cityD.Connection("E", 2);
                    cityD.Connection("C", 4);
                    cityD.Connection("A", 6);

                    cityE.Connection("F", 2);

                    cityF.Connection("E", 2);
                    cityF.Connection("B", 1);

                    //Создание городов по именам
                    //Cities cityA = new Cities("A");
                    //Cities cityB = new Cities("B");
                    //Cities cityC = new Cities("C");

                    //Создание городов со связями
                    //string[] connectionsA = { "B", "F", "D" };
                    //int[] pathsA = { 5, 1, 6 };
                    //Cities cityA = new Cities("A", connectionsA, pathsA);

                    //string[] connectionsB = { "A", "C" };
                    //int[] pathsB = { 5, 3 };
                    //Cities cityB = new Cities("B", connectionsB, pathsB);

                    //string[] connectionsC = { "B", "D" };
                    //int[] pathsC = { 3, 4 };
                    //Cities cityC = new Cities("C", connectionsC, pathsC);

                    //string[] connectionsD = { "E", "C", "A" };
                    //int[] pathsD = { 2, 4, 6 };
                    //Cities cityD = new Cities("D", connectionsD, pathsD);

                    //string[] connectionsE = { "F" };
                    //int[] pathsE = { 2 };
                    //Cities cityE = new Cities("E", connectionsE, pathsE);

                    //string[] connectionsF = { "E", "B" };
                    //int[] pathsF = { 2, 1 };
                    //Cities cityF = new Cities("F", connectionsF, pathsF);

                    Console.WriteLine("Реализуемая схема:");
                    Console.WriteLine(cityA.ToString());
                    Console.WriteLine(cityB.ToString());
                    Console.WriteLine(cityC.ToString());
                    Console.WriteLine(cityD.ToString());
                    Console.WriteLine(cityE.ToString());
                    Console.WriteLine(cityF.ToString());
                    Console.WriteLine();
                    break;
                case 5:
                    int n, d;
                    int n2, d2;
                    int t;
                    Console.WriteLine("Создайте дробь:");                    
                    while(true)
                    {
                        Console.Write("Числитель: ");
                        string input;
                        input = Console.ReadLine();                        
                        if (!inputChecks.ToNumbers(input))
                        {
                            Console.WriteLine("Ошибка ввода. Введите число");
                            continue;
                        }
                        n = Convert.ToInt32(input);
                        break;
                    }                   
                    while (true)
                    {
                        Console.Write("Знаменатель: ");
                        string input;
                        input = Console.ReadLine();
                        if (!inputChecks.ToNumbers(input))
                        {
                            Console.WriteLine("Ошибка ввода. Введите число");
                            continue;
                        }
                        if (input == "0")
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                            continue;
                        }
                        d = Convert.ToInt32(input);
                        break;
                    }
                    Fraction fraction = new Fraction(n, d);
                    Console.Write("Ваша дробь: ");
                    Console.WriteLine(fraction.ToString());
                    Console.WriteLine("Число для действия: ");
                    while (true)
                    {
                        Console.WriteLine("Число какого типа? 1-целого, 2-дробного");
                        string input = Console.ReadLine();
                        if (!inputChecks.ToNumbers(input))
                        {
                            Console.WriteLine("Нет такого варианта выбора! Введите 1 или 2: ");
                            continue;
                        }
                        t = Convert.ToInt32(input);
                        if(t < 1 || t > 2)
                        {
                            Console.WriteLine("Нет такого варианта выбора! Введите 1 или 2: ");
                            continue;
                        }
                        break;
                    }
                    
                    Fraction number = null;
                    if (t == 1)
                    {
                        Console.Write("Введите целое число: ");
                        while (true)
                        {
                            string input;
                            input = Console.ReadLine();
                            if (!inputChecks.ToNumbers(input))
                            {
                                Console.WriteLine("Ошибка ввода. Введите число");
                                continue;
                            }
                            n2 = Convert.ToInt32(input);
                            break;
                        }
                        number = new Fraction(n2, 1);
                    }

                    else if (t == 2)
                    {
                        Console.WriteLine("Введите дробное число: ");
                        Console.Write("Числитель: ");
                        while (true)
                        {
                            string input;
                            input = Console.ReadLine();
                            if (!inputChecks.ToNumbers(input))
                            {
                                Console.WriteLine("Ошибка ввода. Введите число");
                                continue;
                            }
                            n2 = Convert.ToInt32(input);
                            break;
                        }
                        Console.Write("Знаменатель: ");
                        while (true)
                        {
                            string input;
                            input = Console.ReadLine();
                            if (!inputChecks.ToNumbers(input))
                            {
                                Console.WriteLine("Ошибка ввода. Введите число");
                                continue;
                            }
                            if (input == "0")
                            {
                                Console.WriteLine("На ноль делить нельзя!");
                                continue;
                            }
                            d2 = Convert.ToInt32(input);
                            break;
                        }
                        number = new Fraction(n2, d2);
                    }

                    string seenNum = fraction.ToString();

                    Console.Write("Сумма: ");
                    Fraction sum = new Fraction(n, d);
                    sum.Addition(number);
                    Console.WriteLine(seenNum + " + " + number + " = " + sum.ToString());

                    Console.Write("Разность: ");
                    Fraction sub = new Fraction(n, d);
                    sub.Subtraction(number);
                    Console.WriteLine(seenNum + " - " + number + " = " + sub.ToString());

                    Console.Write("Умножение: ");
                    Fraction mult = new Fraction(n, d);
                    mult.Multiplication(number);
                    Console.WriteLine(seenNum + " * " + number + " = " + mult.ToString());

                    Console.Write("Деление: ");
                    Fraction div = new Fraction(n, d);
                    div.Division(number);
                    Console.WriteLine(seenNum + " / " + number + " = " + div.ToString());
                    break;

            }
        }
    }
}