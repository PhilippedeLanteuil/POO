using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_sub
{
    class Program
    {
        static void Main(string[] args)
        {
            Subtracao sub = new Subtracao();
            sub.setN1(70);
            sub.setN2(40);
            sub.setSub(sub.getN1() - sub.getN2());
            Console.WriteLine(sub.getSub());
            Console.ReadKey();

            Subtracao subtrai = new Subtracao();
            subtrai.setN1(50);
            subtrai.setN2(30);
            subtrai.setSub(subtrai.getN1() - subtrai.getN2());
            Console.WriteLine(subtrai.getSub());
            Console.ReadKey();
        }
    }
}
