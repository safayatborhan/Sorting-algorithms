using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_algorithm_representation
{
    class MergeSort
    {
        public int[] A = new int[1000];
        public static int k;
        public void mergeSort(int[] A, int p, int r)
        {
            int q;
            if (p < r)
            {
                q = (p + r) / 2;
                mergeSort(A, p, q);
                mergeSort(A, q + 1, r);
                merge(A, p, q, r);
            }
        }
        public void merge(int[] A, int p, int q, int r)
        {
            int i, j;
            int[] L = new int[100];
            int[] R = new int[100];
            int n1, n2;
            n1 = q - p + 1;
            n2 = r - q;
            for (i = 0; i < n1; i++)
            {
                L[i] = A[p + i - 1];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = A[q + j];
            }
            i = 0;
            j = 0;

            k = p - 1;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    A[k] = L[i];
                    i++;
                }
                else
                {
                    A[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                A[k] = L[i];
                k++;
                i++;
            }

            while (j < n2)
            {
                A[k] = R[j];
                k++;
                j++;
            }
        }
    }
}
