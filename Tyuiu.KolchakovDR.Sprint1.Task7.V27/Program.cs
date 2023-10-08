using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint1.Task7.V27.Lib;
using TaskHeaderGenerator;
namespace Tyuiu.KolchakovDR.Sprint1.Task7.V27
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
                "Добавление к решению итоговых проектов по спринту",
                7,
                27,
                "Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых пользователем. Ответ округлите до 3 знаков после запятой."
                );
            thg.printHeader();
            Console.WriteLine("");
            Console.WriteLine("Формула: z = (cosx^2 + siny^2) / (siny + 1) - (x * y - 12) / (15 + cosx)");
            Console.WriteLine("");
            Console.WriteLine("Введите число Х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            thg.printFooter();
            
            Console.WriteLine("Z = " + ds.Calculate(x,y));

            Console.ReadKey();

        }
    }
}
