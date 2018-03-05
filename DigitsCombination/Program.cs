using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { -44,0,2,2,0,2,46,55 };
            int X = 2;
            FindCouple(a, X);
            Console.ReadKey();
        }

        static void FindCouple(List<int> a, int X)
        {
            bool findout = false;
            for (int i=1;i<a.Count;i++)
            {
                if (X-a[i]==a[0])
                {
                    Console.Write(a[0].ToString() + " " + a[i].ToString()+"\n");
                    findout = true;
                    a.RemoveAt(i);
                    a.RemoveAt(0);
                    FindCouple(a, X);
                }
            }
            if (!findout && a.Count>0)
            {
                a.RemoveAt(0);
                FindCouple(a, X);
            }
        }
    }
}
