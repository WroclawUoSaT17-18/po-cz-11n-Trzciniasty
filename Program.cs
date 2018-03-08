//Poprawić odporność na błedy danych wpisanych z konsoli

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace objetosc_i_pole_3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu:
            Console.WriteLine("Kalulator objetosci i pola figur przestrzennych:");
            Console.WriteLine("------------------------------------------------");
            
            Console.WriteLine("Wybierz figure: \n 1) prostopadloscian \n 2) stozek \n");            
            char caseSwitch = Char.Parse(Console.ReadLine());
            if(char.IsNumber(caseSwitch))
            {
                switch (caseSwitch)
                {
                    case '1':
                        Console.WriteLine("Podaj wymiary:\n a =");
                        Console.SetCursorPosition(5, 8);
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine(" b =");
                        Console.SetCursorPosition(5, 9);
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine(" c =");
                        Console.SetCursorPosition(5, 10);
                        double c = double.Parse(Console.ReadLine());
                        Cube Cube1 = new Cube(a, b, c);
                        Console.WriteLine("PROSTOPADLOSCIAN:");
                        Console.WriteLine("P = {0}", Cube1.Vol());
                        Console.WriteLine("V = {0}\n", Cube1.Area());
                        Console.ReadKey();
                        Console.Clear();
                        goto Menu;
                    case '2':
                        Console.WriteLine("Podaj wymiary:\n r =");
                        Console.SetCursorPosition(5, 8);
                        double r = double.Parse(Console.ReadLine());
                        Console.WriteLine(" h =");
                        Console.SetCursorPosition(5, 9);
                        double h = double.Parse(Console.ReadLine());

                        Cone Cone1 = new Cone(r, h);
                        Console.WriteLine("STOZEK:");
                        Console.WriteLine("P = {0}", Cone1.Vol());
                        Console.WriteLine("V = {0}\n", Cone1.Area());
                        Console.ReadKey();
                        Console.Clear();
                        goto Menu;
                    default:
                        Console.WriteLine("Bledny wybor! \n");
                        Console.ReadKey();
                        Console.Clear();
                        goto Menu;
                }
            }
            else
            {
                Console.WriteLine("Bledny wybor! \n");
                Console.ReadKey();
                Console.Clear();
                goto Menu;
            }         
        }
    }
    public class Cube
    {
        double a = 0;
        double b = 0;
        double c = 0;
       public Cube(double a1, double b1, double c1)
        {
            a = a1;
            b = b1;
            c = c1;
        }
        public double Vol()
        { return a * b * c; }
        public double Area()
        { return 2 * a * b + 2 * a * c * 2 * b * c; }
    }
    public class Cone
    {
        double r = 0;
        double h = 0;
        public Cone(double r1, double h1)
        {
            r = r1;
            h = h1;
        }
        public double Vol()
        { return r * r * h * Math.PI/3; }
        public double Area()
        { return Math.PI * r * r + Math.PI * r * Math.Sqrt(h * h + r * r); }
    }
}


