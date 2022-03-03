using System;

namespace romannumbers
{
    class Program
    {
        //
        //
        //
      static void Main(string[] args)
        {
         try // тест на исключение при 0
           {
            RomanNumber a = new(0);
           }
         catch (RomanNumberException exp)
           {
            Console.WriteLine(exp.Message);
           }

         try // тест на исключение при значении вычитания <= 0
           {
            RomanNumber a = new(64);
            RomanNumber b = new(501);
            a -= b;
            }
         catch (RomanNumberException exp)
           {
            Console.WriteLine(exp.Message);
           }

         try// тест операций с числами
           {
            RomanNumber a = new(111);
            RomanNumber b = new(543);
            RomanNumber c = new(35);
            RomanNumber d = new(12);
            RomanNumber result;
            RomanNumber[] mas = { a, b, c, d };

                    result = a + b;
                Console.WriteLine($"{a} + {b} = {result}");//сложение 111+543
                    result = b - a;
                Console.WriteLine($"{b} - {a} = {result}");//вычитание 543-111
                    result = c / d;
                Console.WriteLine($"{c} / {d} = {result}");//деление 
                    result = c * d;
                Console.WriteLine($"{c} * {d} = {result}");//умножение
                    

                Console.WriteLine("\n Unsorted Array: ");// тесты сортировки
                foreach (RomanNumber num in mas)
                {
                Console.WriteLine(num);
                }
                Array.Sort(mas);

                Console.WriteLine("\n Sorted Array: ");
                foreach (RomanNumber num in mas)
                {
                Console.WriteLine(num);
                }
            }
         catch (RomanNumberException exp)
            {
             Console.WriteLine(exp.Message);
            }
        }
    }
}
