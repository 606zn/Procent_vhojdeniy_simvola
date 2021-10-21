using System;

namespace Procent_vhojdeniy_simvola
{
    class Program
    {
        /// <summary>
        /// Ввести строку произвольной длины и подсчитайте
        /// процент вхождения заданного символа в строку.
        /// </summary>
        /// 
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string vhod;
            Console.WriteLine("Введите строку: ");
            vhod = Console.ReadLine();
            char[] myArray = vhod.ToCharArray(); // вставить символы строки в массив
            Console.Write("Введите искомый символ: ");
            char x = char.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < myArray.Length; i++) //поиск искомого символа в массиве
                if (myArray[i] == x) count++;
            int result = (100 * count) / vhod.Length;
            Console.WriteLine("Процент совпадения искомого символа = " + result + "%");
        }
    }
}
