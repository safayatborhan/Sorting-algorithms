using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithm_representation
{
    class InsertionSort
    {
        private int i, j, key;
        public int[] A = new int[1000];
        public int limit;
        public InsertionSort(int p1)
        {
            limit = p1;
        }
        public void sortedList()
        {
            for (j = 1; j < limit; j++)
            {
                key = A[j];
                i = j - 1;
                while (i >= 0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    --i;
                }
                A[i + 1] = key;
            }
        }
    }
}
