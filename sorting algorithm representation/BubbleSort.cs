using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithm_representation
{
    class BubbleSort
    {
        public int[] A = new int[1000];
        public void bubbleSort(int[] A, int n)
        {
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i] < A[j])
                    {
                        temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }
                }
            }
        }
    }
}
