﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 34;
            int y = 222;
            Addition(ref x, y);

            Console.WriteLine("Результат Sum: " + Sum(10, 15) + "\n");        // параметры передаются по значению]
            Console.WriteLine("Результат Addition: " + x + "\n");
            Console.ReadKey();
            Console.WriteLine("Сравнение передачи параметров. Вариант 1: передача по значению \n");
            
            int a = 5;
            Console.WriteLine($"Начальное значение переменной a: {a}" + "\n");

            IncrimentVal(a);
            Console.WriteLine($"Переменная после передачи по значению равна: {a}" + "\n");

            Console.WriteLine("Сравнение передачи параметров. Вариант 2: передача по ссылке \n\n");

            int b = 111;
            Console.WriteLine($"Начальное значение переменной b: {b}" + "\n");

            IncrimentRef(ref b);
            Console.WriteLine($"Переменная b после передачи по ссылке равна: {b}" + "\n");
            Console.WriteLine("--------- Выходные параметры ----------- \n\n");

        }

        static void IncrimentRef(ref int x)
        {
            x++;
            Console.WriteLine($"IncrementRef: {x}");
        }

        // При передачи значений, функция получает не переменную а её копию
        static int Sum(int x, int y)
        {
            return x + y;
        }

        // Вот тут например метод получает не копию значения переменной, а адрес переменной в памяти по ссылке
        static void Addition(ref int x, int y)
        {
            x += y;
        }

        // пример функции которая меняет переданное в неё значение
        static void IncrimentVal(int x)
        {
            x++;
            Console.WriteLine($"IncrementVal: {x}");
        }

        
    }
}