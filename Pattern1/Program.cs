using System;
using System.Threading;

namespace Pattern1
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread thr = new Thread(() => {
                SingletoneExample s = SingletoneExample.Dat();
                s.CountOne();
            });

            thr.Start();

            Thread thr2 = new Thread(() => {
                SingletoneExample s = SingletoneExample.Dat();
                s.CountOne();
            });

            thr2.Start();
        }
    }
}
