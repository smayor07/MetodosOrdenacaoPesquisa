using System;
using System.Collections.Generic;

namespace MetodosOrdenacao
{
    public class QuickSort
    {
        public  QuickSort()
        {

        }

        public static void Sort(List<int> l)
        {
            Quick(l, 0, l.Count - 1);
        }

        public static void Quick(List<int> v, int begin, int end)
        {
            
            int i, j, k, aux;

            i = begin;
            j = end;

            k = v[((i + j) / 2)];

            while (i <= j)
            {
                while (v[i] < k)
                    i++;
                while (v[j] > k)
                    j--;
                if (i < j)
                {
                    aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;
                    i++;
                    j--;
                }
                else
                {
                    if (i == j)
                    {
                        i++;
                        j--;
                    }
                }
            }

            if (j > begin)
                Quick(v, begin, j);
            if (i < end)
                Quick(v, i, end);
        }

    }
}
