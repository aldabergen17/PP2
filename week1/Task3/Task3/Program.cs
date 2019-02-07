using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// считываем переменную из консоль
            int[] a = new int[n];
            string[] s = new string[n];
            s = Console.ReadLine().Split();//cчитываем с помощи сплит элементов массива
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");//делаю вывод два раза
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}