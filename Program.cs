using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KryptografiaLista1
{
    public class Program
    {
        static void Main(string[] args)
        {
            startZadanie1();
        }

        static void startZadanie1()
        {
            Zadanie1 zadanie1 = new Zadanie1();
            zadanie1.run("208787");
        }
    }
}

