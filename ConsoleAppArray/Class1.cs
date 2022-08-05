using System;


namespace ConsoleAppArray
{
    internal class Class1
    {
        public int[] SortedArray(int[] Ulist)
        {
            int min = Ulist[0];
            for (int k = Ulist.Length; k >= 0; k--)
            {
                for (int i = 1; i < k; i++)
                {

                    int a = Ulist[i - 1];
                    int b = Ulist[i];
                    if (a < b)

                    {

                        Ulist[i] = a;
                        Ulist[i - 1] = b;
                    }

                }

            }
            return Ulist;
        }
    }
}     
