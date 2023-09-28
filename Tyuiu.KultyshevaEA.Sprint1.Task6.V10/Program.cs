using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KultyshevaEA.Sprint1.Task6.V10.Lib;

namespace Tyuiu.KultyshevaEA.Sprint1.Task6.V10
{
    class Program
    {
        static void Main(string[] args)
        { 
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Култышева Е. А. | ИИПБ-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                              *");
            Console.WriteLine("* Выполнила: Култышева Екатерина Александровна | ИИПБ-23-3                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Напечатать все слова, удалив среднюю букву у слов нечетной длины.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string k;

        Console.WriteLine("Введите текст:");
            k = Convert.ToString(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            
            string res = ds.DeleteMiddleLetter(k);
        Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
