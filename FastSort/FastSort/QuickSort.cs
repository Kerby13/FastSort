using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FastSort
{
    class QuickSort
    {
        public class Wrapper
        {
            private int left;
            private int right;
            private int[] mass;
            public Wrapper(int[] _mass, int _left, int _right)
            {
                this.left = _left;
                this.right = _right;
                this.mass = _mass;
            }
            public void TestMethod()
            {
                quickSort(mass, left, right);
            }
        }
        public static void quickSort(int[] a, int l, int r)
        {
            int p = a[(r - l) / 2 + l];
            int temp;
            int i = l, j = r;
            while (i <= j)
            {
                while (a[i] < p && i <= r) ++i;
                while (a[j] > p && j >= l) --j;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    ++i; --j;
                }
            }            

            if (i < r)
            {
                Wrapper data = new Wrapper(a, i, r);
                Thread myThread = new Thread(data.TestMethod);
                myThread.Start();
                myThread.Join();
            }
            if (l < j)
            {
                Wrapper data = new Wrapper(a, l, j);
                Thread myThread = new Thread(data.TestMethod);
                myThread.Start();
                myThread.Join();
            }
        }

        public static void singlequickSort(int[] a, int l, int r)
        {
            int temp;
            int x = a[l + (r - l) / 2];           
            int i = l;
            int j = r;           
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                quickSort(a, i, r);

            if (l < j)
                quickSort(a, l, j);
        }
    }
}
