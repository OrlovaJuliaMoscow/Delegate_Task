using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            //MyDelegate myDelegate = PowerAB;
            //int r = myDelegate(2, 10);
            //Console.WriteLine(r);

            //myDelegate = PowerBA;
            //r= myDelegate(2, 10);   
            //Console.WriteLine(r);

            
            //myDelegate +=Diam;
            //myDelegate(r);
            Console.WriteLine("Enter r");
            double r = Convert.ToDouble(Console.ReadLine());
                       
            MyDelegate myDelegate = Diam;
            myDelegate += Square;
            myDelegate+= Volume;
            Console.ReadKey();
            
        }
        //double Radius(Console.WriteLine("Enter r"));
        //double r = Convert.ToDouble32(Console.ReadLine());
        static double Diam (double r)
        {
            double d = (double)(Math.PI*2*r);
            Console.WriteLine(d);
            return d;
        }

        static double Square(double r)
        {
            double s = (double)(Math.PI * r * r);
            Console.WriteLine(s);
            return s;
        }

        static double Volume(double r)
        {
            double v = (double)(Math.PI * 4/3 * r *r * r);
            Console.WriteLine(v);
            return v;
        }

        //static int PowerBA(int a, int b)
        //{
        //    int r = (int)Math.Pow(b, a);
        //    Console.WriteLine(r);
        //    return r;
        //}

        //////static int PowerAB(int a, int b) => (int)Math.Pow(a, b);
        //////static int PowerBA(int a, int b) => (int)Math.Pow(b, a);
        //{
        //    // //return (int) Math.Round (Math.Pow (a, b));   
        //    //int p = 1;
        //    //for (int i = 0; i < b; i++)
        //    //{
        //    //    p *= a;
        //    //}; 

        //}

    }
}