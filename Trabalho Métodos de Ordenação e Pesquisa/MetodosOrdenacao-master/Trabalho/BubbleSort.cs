using System;
using System.Collections.Generic;

namespace MetodosOrdenacao
{
    public class BubbleSort
    {
        public  BubbleSort()
        {

        }

        public static void Sort(List<int> l)
        {
            bool troca;
            do
            {
                troca = false;
                for(int i = 0; i < l.Count - 1 ; i ++)
                {
                    if(l[i] > l[i + 1] )
                    {
                        int k = l[i];
                        l[i] = l[i + 1];
                        l[i + 1] = k ;
                        troca = true;
                    }
                } 

            }while(troca);

            
        }

    }
}
