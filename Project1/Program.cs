using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "Classes", "Students", "Teachers" };
            Options(items);
            submenu(items);
        }
        public static void Options(string[] str)
        {
            int s = 28;
            space(s);
            Console.WriteLine("------------");
            space(s - 1);
            Console.WriteLine("| A. Manage  |");
            space(s - 1);
            Console.WriteLine("|   {0}  |", str[0]);
            space(s);
            Console.WriteLine("------------");
            body();
            s = 2;
            space(s);
            Console.Write("------------");
            space(36);
            Console.WriteLine("------------");
            space(s - 1);
            Console.Write("| B. Manage  |");
            space(34);
            Console.WriteLine("| C. Manage  |");
            space(s - 1);
            Console.Write("|  {0}  |", str[1]);
            space(34);
            Console.WriteLine("|  {0}  |", str[2]);
            space(s);
            Console.Write("------------");
            space(36);
            Console.WriteLine("------------");

        }
        public static void body()
        {
            int n, c = 17;
            for (int j = 0; j < 15; j++)
            {
                n = 42 + j;
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(" ");
                    if (((j == 8) & (i == 25)) || ((j == 10) & (i == 22)))
                    {
                        int k;
                        if (j == 8)
                        {
                            k = i + 15;
                        }
                        else
                        {
                            k = i + 20;
                        }
                        for (i = (j == 8) ? 25 : 22; i <= k; i++)
                        {
                            Console.Write("-");
                        }
                    }
                    if (j == 9 & i == 23)
                    {
                        Console.Write(@"/ Enter an option \");
                        i = 42;
                    }
                    if (i == (n - c))
                    {
                        Console.Write("*");
                        c += 2;
                    }
                    if (i == n)
                    {
                        Console.WriteLine("*");
                    }
                }

            }
        }
        public static void space(int s)
        {
            for (int i = 1; i <= s; i++)
            {
                Console.Write(" ");
            }
        }
        public static void submenu(string[] str)
        {
            for (int j = 0; j <= 63; j++)
            {
                Console.Write("-");
            }
            Console.Write("\nChoose An Options : ");
            int i = 0;
            char a = Convert.ToChar(Console.ReadLine().ToLower());
            switch (a)
            {
                case 'a':
                    i = 0;
                    break;
                case 'b':
                    i = 1;
                    break;
                case 'c':
                    i = 2;
                    break;
                default:
                    Console.WriteLine("Wrong Input!!!");
                    return;
            }
            Console.WriteLine("\n1) Show List Of {0}", str[i]);
            Console.WriteLine("2) Add {0}", str[i]);
            Console.WriteLine("3) Edit {0}", str[i]);
            Console.WriteLine("4) Delete {0}", str[i]);
            Console.WriteLine("5) Back ");
            Console.WriteLine("6) Exit ");
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
