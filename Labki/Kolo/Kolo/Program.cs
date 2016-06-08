using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo
{
        delegate int Delegacja(int i);
        class A
        {
            public event Delegacja SieDzieje;
            public int i = 3;
            public void DoRoboty(int i)
            {
                if (SieDzieje != null)
                    this.i += SieDzieje(i);
                else this.i = i;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                A a = new A();
                a.DoRoboty(5);
                Console.WriteLine("{0}", a.i);
                Delegacja raz = x => { Console.WriteLine("raz"); return x + 1; };
                a.SieDzieje += new Delegacja(raz);
                a.DoRoboty(a.i);
                Console.WriteLine("{0}", a.i);
                a.SieDzieje += new Delegacja(delegate(int x)
                { Console.WriteLine("dwa {0}", x + a.i); return 2 + x; });
                a.DoRoboty(a.i);
                Console.WriteLine("{0}", a.i);
                a.SieDzieje += new Delegacja(raz);
                a.DoRoboty(a.i);
                Console.WriteLine("{0}", a.i);
            }
        }
}
