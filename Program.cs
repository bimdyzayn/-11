using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class MyClass
    {

        private double k;
        private double b;
        private double o;
        private double x;

        public MyClass(double A, double B, double Y)
        {
            k = A;
            b = B;
            o = Y;
        }
        public void Read(double a1, double b1)
        {
            k = a1;
            b = b1;
            root();
        }
        public void root()
        {
            if (k != 0) x = (o - b) / k;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("Значение х : {0}", x);
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MyClass qwr = new MyClass(0, 0, 0);
            Console.Write("Введите значение k: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double j = Convert.ToDouble(Console.ReadLine());

            double s = 0;
      
            qwr.Read(h, j - s);

        }
    }
}
