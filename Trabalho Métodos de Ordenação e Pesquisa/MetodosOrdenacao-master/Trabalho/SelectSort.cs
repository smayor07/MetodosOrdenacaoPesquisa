using System;
using System.Collections.Generic;


namespace MetodosOrdenacao
{
    public class SelectSort
    {
        public SelectSort()
        {

        }

        public static void Sort(List<int> l)
        {
            for (int i = 0; i < l.Count; i++)
            {
                int ik = i;
                for (int j = i + 1; j < l.Count; j++)
                {
                    if (l[j] < l[ik])
                    {
                        ik = j;
                    }
                }

                int k = l[i];
                l[i] = l[ik];
                l[ik] = k;
            }
        }

    }
}
