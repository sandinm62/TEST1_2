using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    //Сандин Михаил
    // Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ)
    // по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.
    internal class Program
    {
        static void Main(string[] args)
        {
            double mass, growth, i;
            Console.Write("Enter you mass (Kg): ");
            mass = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter you growth (m): ");
            growth = Convert.ToDouble(Console.ReadLine());
            i = mass / (growth * growth);
            Console.Clear();
            Console.WriteLine("You body mass index: " + "{0:F}", i); //выводим индекс массы тела и округляем колличество знаков после запятой до двух символо
            Console.ReadKey();



        }
    }
}
