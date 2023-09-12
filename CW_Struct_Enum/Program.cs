using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CW_Struct_Enum
{

    struct Deci
    {
        private int _deci;
        public Deci(int deci)
        {
            _deci = deci;
        }

        public int Dec
        {
            get
            {
                return _deci;
            }
            set
            {
                _deci = value;
            }
        }
        public int[] toBin()
        {
            int[] bin;
            bool resume = true;
            int count = 0;
            int copy = _deci;
            for (count = 0; resume; count++)
            {
                if (copy > 2)
                {
                    copy /= 2;
                }
                else
                {
                    if (copy == 2)
                    {
                        count += 1;
                    }
                    resume = false;
                }
            }
            bin = new int[count];
            copy = _deci;
            count--;
            for (int i = 0; i < count + 1; i++)
            {
                if (copy % 2 == 1)
                {
                    bin[count - i] = 1;
                    copy /= 2;
                }
                else
                {
                    bin[count - i] = 0;
                    copy /= 2;
                }
            }
            return bin;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Deci test = new Deci();
            int enter = 0;
            enter = Convert.ToInt32(Console.ReadLine());
            test.Dec = enter;
            int[] bin = test.toBin();
            foreach (int i in bin)
            {
                Console.Write(i);
            }
            Console.WriteLine('\n');
        }
    }
}
