using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hendese
{
    class Triangle
    {
        private double a;//ضلع
        private double b;
        private double c;
        private double h;//ارتفاع
        public double A
        {
            get { return a; }
            set
            {
                if (a > 0)
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (b > 0)
                {
                    b = value;
                }
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (c > 0)
                {
                    c = value;
                }
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (h > 0)
                {
                    h = value;
                }
            }
        }

        public Triangle() { }//تابع مخرب
        public Triangle(double A, double B, double C, double H)
        {
            a = A;
            b = B;
            c = C;
            h = H;
        }
        public double Area1()
        {
            return (a * h) / 2;
        }
        public double Perimeter1()
        {
            return a + b + c;
        }
    }//end class Triangle
    class Squre
    {
        private double a;//ضلع
        public double A
        {
            get { return a; }
            set
            {
                if (a > 0)
                {
                    a = value;
                }
            }
        }
        public Squre() { }//تابع مخرب
        public Squre(double A)
        {
            a = A;
        }
        public double Area2()
        {
            return Math.Pow(a, 2);
        }
        public double Perimeter2()
        {
            return 4 * a;
        }
    }//end class Squre
    class Rectangle
    {
        private double a;//طول
        private double b;//عرض
        public double A
        {
            get { return a; }
            set
            {
                if (a > 0)
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (b > 0)
                {
                    b = value;
                }
            }
        }
        public Rectangle() { }//تابع مخرب
        public Rectangle(double A, double B)
        {
            a = A;
            b = B;
        }
        public double Area3()
        {
            return a * b;
        }
        public double Perimeter3()
        {
            return 2 * a + 2 * b;
        }
    }//end class Rectangle
    class Circle
    {
        private double r;//شعاع
        double pi = 3.14;
        public double R
        {
            get { return r; }
            set
            {
                if (r > 0)
                {
                    r = value;
                }
            }
        }
        public Circle() { }//تابع مخرب
        public Circle(double R)
        {
            r = R;
        }
        public double Area4()
        {
            return pi * Math.Pow(r, 2);
        }
        public double Perimeter4()
        {
            return 2 * r * pi;
        }
    }//end class circle
    class Trapezoid
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double h;
        public double A
        {
            get { return a; }
            set
            {
                if (a > 0)
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (b > 0)
                {
                    b = value;
                }
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (c > 0)
                {
                    c = value;
                }
            }
        }
        public double D
        {
            get { return d; }
            set
            {
                if (d > 0)
                {
                    d = value;
                }
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (h > 0)
                {
                    h = value;
                }
            }
        }
        public Trapezoid() { }//تابع مخرب
        public Trapezoid(double A, double B, double C, double D, double H)
        {
            a = A;//قاعده
            b = B;//قاعده
            c = C;
            d = D;
            h = H;//ارتفاع
        }
        public double Area5()
        {
            return ((a + b) / 2) * h;
        }
        public double Perimeter5()
        {
            return a + b + c + d;
        }
    }//end class Trapezoid
    class Ellipse
    {
        private double a;//شعاع اول
        private double b;//شعاع دوم
        double pi = 3.14;
        public double A
        {
            get { return a; }
            set
            {
                if (a < 0)
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (b < 0)
                {
                    b = value;
                }
            }
        }
        public Ellipse() { }//تابع مخرب
        public Ellipse(double A, double B)
        {
            a = A;
            b = B;
        }
        public double Area6()
        {
            return pi * a * b;
        }
        public double Perimeter6()
        {
            return (a + b) * pi;
        }
    }//end class Ellipse
    class Polygon
    {
        private double a;//طول ضلع  
        private double n;//تعداد اضلاع
        private double h;//ارتفاع
        public double A
        {
            get { return a; }
            set
            {
                if (a > 0)
                {
                    a = value;
                }
            }
        }
        public double N
        {
            get { return n; }
            set
            {
                if (n > 0)
                {
                    n = value;
                }
            }
        }
        public double H
        {
            get { return h; }
            set
            {
                if (h > 0)
                {
                    h = value;
                }
            }
        }
        public Polygon() { }//تابع مخرب
        public Polygon(double A, double N, double H)
        {
            a = A;
            n = N;
            h = H;
        }
        public double Area7()
        {
            return (n * a * h) / 2;
        }
        public double Perimeter7()
        {
            return a * n;
        }
    }//end class Polygon
    class Test
    {
        public static void Main()
        {
            Console.WriteLine("please choose your shape:");
            Console.WriteLine("1-Triangle   2-Squre   3-Rectangle   4-Circle   5-Trapezoid   6-Ellipse   7-Polygon");
            Console.Write("shape number: ");
            double choose = Convert.ToDouble(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Please enter triangle's edges & altitude:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c = ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("h = ");
                double h = Convert.ToDouble(Console.ReadLine());
                Triangle T1 = new Triangle(a, b, c, h);
                double A1 = T1.Area1();
                Console.Write("Area = ");
                Console.WriteLine(A1);
                double P1 = T1.Perimeter1();
                Console.Write("Perimeter = ");
                Console.WriteLine(P1);
            }
            else if (choose == 2)
            {
                Console.WriteLine("Please enter the squre's edge:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Squre S1 = new Squre(a);
                double A2 = S1.Area2();
                Console.Write("Area = ");
                Console.WriteLine(A2);
                double P2 = S1.Perimeter2();
                Console.Write("Perimeter = ");
                Console.WriteLine(P2);
            }
            else if (choose == 3)
            {
                Console.WriteLine("Please enter the Rectangle's edges:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Rectangle R1 = new Rectangle(a, b);
                double A3 = R1.Area3();
                Console.Write("Area = ");
                Console.WriteLine(A3);
                double P3 = R1.Perimeter3();
                Console.Write("Perimeter = ");
                Console.WriteLine(P3);
            }
            else if (choose == 4)
            {
                Console.WriteLine("Please enter the Circle's radius:");
                Console.Write("r = ");
                double r = Convert.ToDouble(Console.ReadLine());
                Circle C1 = new Circle(r);
                double A4 = C1.Area4();
                Console.Write("Area = ");
                Console.WriteLine(A4);
                double P4 = C1.Perimeter4();
                Console.Write("Perimeter = ");
                Console.WriteLine(P4);
            }
            else if (choose == 5)
            {
                Console.WriteLine("Please enter Trapezoid's edges & altitude:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("c = ");
                double c = Convert.ToDouble(Console.ReadLine());
                Console.Write("d = ");
                double d = Convert.ToDouble(Console.ReadLine());
                Console.Write("h = ");
                double h = Convert.ToDouble(Console.ReadLine());
                Trapezoid TR1 = new Trapezoid(a, b, c, d, h);
                double A5 = TR1.Area5();
                Console.Write("Area = ");
                Console.WriteLine(A5);
                double P5 = TR1.Perimeter5();
                Console.Write("Perimeter = ");
                Console.WriteLine(P5);
            }
            else if (choose == 6)
            {
                Console.WriteLine("Please enter Ellipse's radiuses:");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("b = ");
                double b = Convert.ToDouble(Console.ReadLine());
                Ellipse E1 = new Ellipse(a, b);
                double A6 = E1.Area6();
                Console.Write("Area = ");
                Console.WriteLine(A6);
                double P6 = E1.Perimeter6();
                Console.Write("Perimeter = ");
                Console.WriteLine(P6);
            }
            else if (choose == 7)
            {
                Console.WriteLine("Please enter the number of Ellipse's edge:");
                Console.Write("n = ");
                double n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter Ellipse's edge & altitude size :");
                Console.Write("a = ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("h = ");
                double h = Convert.ToDouble(Console.ReadLine());
                Polygon PL1 = new Polygon(a, n, h);
                double A7 = PL1.Area7();
                Console.Write("Area = ");
                Console.WriteLine(A7);
                double P7 = PL1.Perimeter7();
                Console.Write("Perimeter = ");
                Console.WriteLine(P7);
            }
            else
            {
                Console.WriteLine("please choose a correct shape!");
            }
        }//end main
    }//end class Test
}//end namespace






