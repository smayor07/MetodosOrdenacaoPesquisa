using System;
using System.Collections.Generic;

namespace MetodosOrdenacao
{
    public class ShellSort
    {
        public  ShellSort()
        {

        }

        public static void Sort(List<int> l)
        {
            int i, j , k;
            int h = 1;
            
            while(h < l.Count)
            {
                h = 3 * h + 1;
            }

            while(h > 1)
            {
                h /= 3;

                for(i = h; i < l.Count; i++)
                {
                    k = l[i];
                    j = i;
                    while(j >= h && k < l[j - h])
                    {
                        l[j] = l[j - h];
                        j -= h;
                    }
                    l[j] = k;
                }

            }
        }

    }
}
