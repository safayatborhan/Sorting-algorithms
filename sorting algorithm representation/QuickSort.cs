using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithm_representation
{
    class QuickSort
    {
        public int[] A = new int[1000];
        public void quickSort(int[] A, int p, int r)
        {
            int q;
            if (p < r)
            {
                q = Partition(A, p, r);
                quickSort(A, p, q - 1);
                quickSort(A, q + 1, r);
            }
        }
        public int Partition(int[] A, int p, int r)
        {
            int i, j, x, temp;

            x = A[r];
            i = p - 1;
            for (j = p; j < r; j++)
            {
                if (A[j] <= x)
                {
                    i++;
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
            temp = A[i + 1];
            A[i + 1] = A[r];
            A[r] = temp;
            return (i + 1);
        }
    }
}
