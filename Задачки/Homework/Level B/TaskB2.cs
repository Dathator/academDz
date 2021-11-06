using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача B2.
    // Кол-во стингеров: 🔹
    //
    // Написать функцию OrderWeight(List<int> list), которая сортирует список положительных чисел.
    // Критерий сортировки - возрастание веса числа (сумма всех цифр числа).
    // Если два числа имеют одинаковый вес, сортировать их так, словно они строки.
    //
    // Пример:
    // [56, 65, 74, 100, 99, 68, 86, 180, 90] ==>
    // [100, 180, 90, 56, 65, 74, 68, 86, 99]
    public static class TaskB2
    {
        public static List<int> OrderWeight(List<int> list)
        {
            // Здесь необходимо написать код.
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> keys = new List<int>();
            int sum;
            string numstr;
            for (int i = 0; i < list.Count; i++)
            {
                sum = 0;
                numstr = Convert.ToString(list[i]);
                for (int j = 0; j < numstr.Length; j++)
                    sum += numstr[j];
                dict[sum] = list[i];
                keys.Add(sum);
            }
            keys.Sort();
            return null;
        }
    }
}
