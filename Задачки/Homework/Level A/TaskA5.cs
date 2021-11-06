using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А5.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию ArrayOfTiers(int number), которая принимает число и возвращает список чисел, 
    // последовательно отсеченных по одному разряду.
    //
    // Пример:
    // ArrayOfTiers(420) ==> [4, 42, 420]
    // ArrayOfTiers(2021) ==> [2, 20, 202, 2021]
    public static class TaskA5
    {
        public static List<int> ArrayOfTiers(int number)
        {
            // Здесь необходимо написать код.
            string numstr = Convert.ToString(number);
            List<int> list = new List<int>();
            for (int i = 0; i < numstr.Length; i++)
            {
                List<string> list2 = new List<string>();
                for (int j = 0; j <= i; j++)
                    list2.Add(Convert.ToString(numstr[j]));
                list.Add(int.Parse(string.Join("", list2)));
            }
            return list;
        }
    }
}
