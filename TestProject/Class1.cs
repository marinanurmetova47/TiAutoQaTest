using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter coordinate x of dot A:");
            double XofA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter coordinate y of dot A:");
            double YofA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter coordinate x of dot B:");
            double XofB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter coordinate y of dot B:");
            double YofB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter coordinate x of dot C:");
            double XofC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter coordinate y of dot C:");
            double YofC = Convert.ToDouble(Console.ReadLine());

            double XofAB, YofAB, XofAC, YofAC, XofBC, YofBC, AB, AC, BC, PABC;
            //Task 1 Sides length
            XofAB = XofB - XofA;
            YofAB = YofB - YofA;
            AB = Math.Sqrt(Math.Pow(XofAB, 2) + Math.Pow(YofAB, 2));
            double ABS = Math.Pow(AB, 2);
            ABS = Math.Round(ABS, 2);
            XofAC = XofC - XofA;
            YofAC = YofC - YofA;
            AC = Math.Sqrt(Math.Pow(XofAC, 2) + Math.Pow(YofAC, 2));
            double ACS = Math.Pow(AC, 2);
            ACS = Math.Round(ACS, 2);
            XofBC = XofC - XofB;
            YofBC = YofC - YofB;
            BC = Math.Sqrt(Math.Pow(XofBC, 2) + Math.Pow(YofBC, 2));
            double BCS = Math.Pow(BC, 2);
            BCS = Math.Round(BCS, 2);
            Console.WriteLine("Length of AB:" + AB);
            Console.WriteLine("Length of AC:" + AC);
            Console.WriteLine("Length of BC:" + BC);
            //Task 2 Equilaeral
            if (AB == BC && AB == AC)
            {
                Console.WriteLine("Triangle is Equilaeral");
            }
            else
            {
                Console.WriteLine("Triangle is not Equilaeral");
            }
            //Task 3 Isosceles
            if (AB == BC || AB == AC ||  BC == AC)
            {
                Console.WriteLine("Triangle is Isosceles");
            }
            else
            {
                Console.WriteLine("Triangle is not Isosceles");
            }
            //Task 4 Right
            if (ABS + BCS == ACS || ACS + BCS == ABS || ABS + ACS == BCS)
            {
                Console.WriteLine("Triangle is Right");
            }
            else
            {
                Console.WriteLine("Triangle is not Right");
            }
            //Task 5 Perimeter
            PABC = AB + BC + AC;
            Console.WriteLine("Perimeter:" + PABC);
            //Task 6 Even numbers
            for (int i = 0; i < PABC; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
