using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Найти сумму n целых, случайных чисел (ДСЧ), распределенных в
диапазоне от 0 до n и меньше n/2. Вывести на экран на одной
строке сгенерированные числа, на другой строке результат.*/

namespace ClassLibrary1
{
    public class Class1
    {
        public static int Summa(int n, out string values)
        {
            Random rnd = new Random();
            int sum = 0;
            values = string.Empty;
            for (int i = 0 ; i < n ; i++)
            {
                int rand = rnd.Next(0, n);

                if (rand < n/2)
                {
                    sum+=rand;
                }
                values += Convert.ToString(rand + " ; ");
            }
            return sum;

        }
    }
}
