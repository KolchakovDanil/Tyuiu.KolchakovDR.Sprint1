using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint1.Task5.V3.Lib;
using TaskHeaderGenerator;
namespace Tyuiu.KolchakovDR.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            TaskHG thg = new TaskHG(
                1,
                "Колчаков Д. Р.",
                "ИИПб-23-2",
                "Алгоритмы линейной структуры",
                5,
                3,
                "Написать программу, которая решает следующую задачу: Присвоить целой переменной h третью от конца цифру в записи положительного целого числа k(например, если k = 130985, то h = 9)."
                );
            thg.printHeader();

            Console.WriteLine("Введите целое число >= 100 (в противном случае ответ будет равен нулю): ");
            int k = Convert.ToInt32(Console.ReadLine());
            thg.printFooter();
            Console.WriteLine(ds.Calculate(k));

            Console.ReadKey();
        }
        
    }
}

