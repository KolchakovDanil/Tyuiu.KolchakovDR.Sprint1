using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint1.Task6.V16.Lib;
using TaskHeaderGenerator;
namespace Tyuiu.KolchakovDR.Sprint1.Task6.V16
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
                "Работа со строками класс String",
                6,
                16,
                "Написать программу: пользователь вводит текст. Проверить, что в строке есть восклицание (!) и вопрос (?)."
                );
            thg.printHeader();

            Console.WriteLine("Введите текст: ");
            string text = Convert.ToString(Console.ReadLine());
            thg.printFooter();
            Console.WriteLine(ds.CheckSpecSymbols(text));

            Console.ReadKey();
        }
    }
}
