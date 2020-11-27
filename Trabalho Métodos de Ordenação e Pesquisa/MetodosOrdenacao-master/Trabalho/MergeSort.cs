using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho
{
    public class MergeSortC
    {

        public static List<int> MergeSorted(int[] L)
        {
            MergeSort(L);
            return L.ToList();
        }

        public static void MergeSort(int[] v, int l, int r)
        {
            if (l < r)
            {
                int m = (l / 2) + (r / 2);
                MergeSort(v, l, m);
                MergeSort(v, m + 1, r);
                Merge(v, l, m, r);
            }
        }

        public static void MergeSort(int[] v)
        {
            MergeSort(v, 0, v.Length - 1);
        }

        private static void Merge(int[] v, int l, int m, int r)
        {

            int left = l;
            int right = m + 1;
            int[] aux = new int[(r - l) + 1];
            int auxIndex = 0;

            while ((left <= m) && (right <= r))
            {
                if (v[left] < v[right])
                {
                    aux[auxIndex] = v[left];
                    left = left + 1;
                }
                else
                {
                    aux[auxIndex] = v[right];
                    right = right + 1;
                }
                auxIndex = auxIndex + 1;
            }

            if (left <= m)
            {
                while (left <= m)
                {
                    aux[auxIndex] = v[left];
                    left = left + 1;
                    auxIndex = auxIndex + 1;
                }
            }

            if (right <= r)
            {
                while (right <= r)
                {
                    aux[auxIndex] = v[right];
                    right = right + 1;
                    auxIndex = auxIndex + 1;
                }
            }

            for (int i = 0; i < aux.Length; i++)
            {
                v[l + i] = aux[i];
            }

        }

       
    }
}
