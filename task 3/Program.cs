using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введіть розмірність матриці: ");
            int nix = Convert.ToInt32(Console.ReadLine());
            Matr massive1 = new Matr(nix);
            Matr massive2 = new Matr(nix);
            Console.WriteLine("Матриця А: ");
            massive1.WriteMat();
            Console.WriteLine("Матриця B: ");
            massive2.WriteMat();
            Console.WriteLine("Матриця А: ");
            massive1.ReadMat();
            Console.WriteLine();
            Console.WriteLine("Матриця В: ");
            Console.WriteLine();
            massive2.ReadMat();
            Console.ReadKey();
        }
    }
    class Matr
    {
        private int n;
        private int[,] mass;

        public Matr() { }
        public int N
        {
            get { return n; }
            set { if (value > 0) n = value; }
        }

        public Matr(int n)
        {
            this.n = n;
            mass = new int[this.n, this.n];
        }
        public int this[int i, int j]
        {
            get
            {
                return mass[i, j];
            }
            set
            {
                mass[i, j] = value;
            }
        }

        public void WriteMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введіть елемент матриці {0}:{1}", i + 1, j + 1);
                    mass[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void ReadMat()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }



        public void oneMat(Matr a)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == 1 && i == j)
                    {
                        count++;
                    }
                }

            }
            if (count == a.N)
            {
                Console.WriteLine("Одинична");
            }
            else Console.WriteLine("Матриця не одинична");
        }



        public static Matr u(Matr a, int ch)
        {
            Matr resMass = new Matr(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.N; j++)
                {
                    resMass[i, j] = a[i, j] * ch;
                }
            }
            return resMass;
        }


        public static Matr p(Matr a, Matr b)
        {
            Matr resMass = new Matr(a.N);
            for (int i = 0; i < a.N; i++)
                for (int j = 0; j < b.N; j++)
                    for (int k = 0; k < b.N; k++)
                        resMass[i, j] += a[i, k] * b[k, j];

            return resMass;
        }




        public static Matr operator *(Matr a, Matr b)
        {
            return Matr.p(a, b);
        }

        public static Matr operator *(Matr a, int b)
        {
            return Matr.u(a, b);
        }


        public static Matr dif(Matr a, Matr b)
        {
            Matr resMass = new Matr(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.N; j++)
                {
                    resMass[i, j] = a[i, j] - b[i, j];
                }
            }
            return resMass;
        }

        public static Matr operator -(Matr a, Matr b)
        {
            return Matr.dif(a, b);
        }
        public static Matr Sum(Matr a, Matr b)
        {
            Matr resMass = new Matr(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.N; j++)
                {
                    resMass[i, j] = a[i, j] + b[i, j];
                }
            }
            return resMass;
        }

        public static Matr operator +(Matr a, Matr b)
        {
            return Matr.Sum(a, b);
        }

        ~Matr()
        {
            Console.WriteLine(".");
        }

    }
}
