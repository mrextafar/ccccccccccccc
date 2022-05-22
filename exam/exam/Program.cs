using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace exam
{
    public struct HowSimbol
    {
        int А;
        int Б;
        int В;
        int Space;
        public int HowMuchА
        {
            get { return А; }
            set { А++; }
        }
        public int HowMuchБ
        {
            get { return Б; }
            set { Б++; }
        }
        public int HowMuchВ
        {
            get { return В; }
            set { В++; }
        }

        public int HowMuchSpace
        {
            get { return Space; }
            set { Space++; }
        }

    }
    class Program
    {



        string[] Stroky;

        public void pathfile(string str)
        {
            Stroky = File.ReadAllLines(str, Encoding.Default);
        }

        HowSimbol Rashet()
        {
            HowSimbol X = new HowSimbol();
            int i = 0;
            string stroka;
            char p;
            while (i <= Stroky.Length - 1)
            {
                {
                    stroka = Stroky[i];
                    stroka = stroka.ToUpper();
                }
                for (int a = 0; a < stroka.Length; a++)
                {
                    p = stroka[a];
                    switch (p)
                    {
                        case 'А':
                            X.HowMuchА = X.HowMuchА;
                            break;
                        case 'Б':
                            X.HowMuchБ = X.HowMuchБ;
                            break;

                        case 'В':
                            X.HowMuchВ = X.HowMuchВ;
                            break;
                        case ' ':
                            X.HowMuchSpace = X.HowMuchSpace;
                            break;
                    }
                }
                i++;
            }
            return X;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter path");
            string s = Console.ReadLine();
            Program R = new Program();
            R.pathfile(s);

            HowSimbol N = R.Rashet();
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Stata.txt");
                sw.WriteLine("Число букв А в тексте = {0}", N.HowMuchА);
                sw.WriteLine("Число букв Б в тексте = {0}", N.HowMuchБ);
                sw.WriteLine("Число букв В в тексте = {0}", N.HowMuchВ);
                sw.WriteLine("Число пробелов в тексте = {0}", N.HowMuchSpace);
                sw.Close();
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
    }
}