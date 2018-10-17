using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern1
{
    public class SingletoneExample
    {

        private SingletoneExample()
        {

        }

        public void CountOne()
        {
            lock(dat)
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }


        private static SingletoneExample dat;
        public static SingletoneExample Dat ()
        {
            if (dat == null)
                dat = new SingletoneExample();

                return dat;
        }
    }
}
