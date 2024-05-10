using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace zad1pr16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Слон и моська. Слон повстречал моську и СЛОН…"
            WriteLine("ВВедите строку");
            string text = ReadLine();
            WriteLine("ВВедите слово,которое будем искать");
            string query = ReadLine();

            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?', '-', '—', '…', '"' }, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Count(w => w.ToLower() == query.ToLower());
            if (count > 0)
            {
                WriteLine($"Были найдены {count} вхождения(ий) поискового запроса ({query})");
            }
            else
            { WriteLine($"({query}) В тексте не найдено"); }
            ReadKey();
        }
    }
}
