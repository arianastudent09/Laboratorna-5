using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть радіус = ");
            Cone.R = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть висоту = ");
            Cone.H = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть радіус зрізаного конусу = ");
            Cone.r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть висоту зрізаного конусу = ");
            Cone.h = Convert.ToDouble(Console.ReadLine());
            Cone.Space(Cone.R);
            Cone.Volume(Cone.H, Cone.R);
            UnCone.UnVolume(Cone.h, Cone.R, Cone.r);
            Console.ReadLine();
        }
    }
    class Cone
    {
        public static double R;
        public static double H;
        public static double r;
        public static double h;

        public static void Space(double R)
        {
            double s = Math.PI * R * R;
            Console.WriteLine("Площа конусу = {0}", s);
        }
        public static void Volume(double H, double R)
        {
            double w = (Math.PI * R * R * H) / 3;
            Console.WriteLine("Об'єм конусу = {0}", w);
        }
    }
    class UnCone : Cone
    {
        public static void UnVolume(double h, double R, double r)
        {
            double U = (Math.PI * h * (R * R + R * r + r * r)) / 3;
            Console.WriteLine("Об'єм зрізаного конусу = {0}", U);
        }
    }

}
