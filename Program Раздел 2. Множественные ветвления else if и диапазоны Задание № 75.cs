using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите октановое число бензина: ");

            // Проверка корректности ввода (поддерживает и целые, и дробные значения)
            if (!double.TryParse(Console.ReadLine(), out double octane))
            {
                Console.WriteLine("Ошибка: введите корректное число.");
                return;
            }

            string classification;

            if (octane < 92)
            {
                classification = "Несоответствие стандарту";
            }
            else if (octane == 92)
            {
                classification = "АИ-92";
            }
            else if (octane == 95)
            {
                classification = "АИ-95";
            }
            else if (octane >= 98 && octane <= 100)
            {
                classification = "АИ-98/100";
            }
            else // octane > 100
            {
                classification = "Спорт/авиатопливо";
            }

            Console.WriteLine(classification);
        }
    }
}