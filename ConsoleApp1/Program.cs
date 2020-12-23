using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рабочаяя_лаб_2
{
    class Program
    {
     

        public static void NumberOfLetters()
        {
            Console.WriteLine("Введите строку: ");
            string letters = Console.ReadLine();
            Console.WriteLine("Ваша строка: ");
            Console.WriteLine(letters);
            char[] vowels = { 'а', 'о', 'у', 'ы', 'э', 'и', 'я', 'ю', 'е', 'ё' };
            Dictionary<char, int> dict = new Dictionary<char, int>(vowels.Length);
            foreach (char ch in vowels)
                dict.Add(ch, 0);
            foreach (char ch in letters)
            {
                if (dict.ContainsKey(ch))
                    dict[ch]++;
            }
            foreach (KeyValuePair<char, int> kv in dict)
            {
                Console.WriteLine("{0} : {1}", kv.Key, kv.Value);
            }
        }

    }
}