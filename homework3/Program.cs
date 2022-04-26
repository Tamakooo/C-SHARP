using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory fac = new Factory();
            for (int i = 0; i < 10; i++)
            {
                fac.RadomShape();
            }
            Console.ReadLine();
        }
    }

    abstract class Polygon
    {
        public double area;
        public Polygon() { }
        public abstract double OutputArea();
        public abstract bool legal();
        public void Show()
        {
            Console.WriteLine("Shape:" + GetType().Name);
            Console.WriteLine("legal:" + legal());
            if (legal())
            {
                Console.WriteLine("Area:" + OutputArea());
            }
            Console.WriteLine();
        }
    }

    class Rectangle : Polygon
    {
        public Rectangle(double len, double wid)
        {
            this.len = len;
            this.wid = wid;
        }
        private double len;
        private double wid;
        public override double OutputArea()
        {
            this.area = len * wid;
            return area;
        }
        public override bool legal()
        {
            if (len < 0 || wid < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    class Square : Polygon
    {
        private double edg;
        public Square(double edg)
        {
            this.edg = edg;
        }
        public override double OutputArea()
        {
            this.area = edg * edg;
            return area;
        }
        public override bool legal()
        {
            if (edg < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    class Triangle : Polygon
    {
        private double sid1;
        private double sid2;
        private double sid3;
        public Triangle(double sid1, double sid2, double sid3)
        {
            this.sid1 = sid1;
            this.sid2 = sid2;
            this.sid3 = sid3;
        }
        public override double OutputArea()
        {
            this.area = Math.Sqrt((sid1 + sid2 + sid3) * (sid1 + sid2 - sid3) * (sid1 - sid2 + sid3) * (sid2 - sid1 + sid3)) / 4;
            return area;
        }
        public override bool legal()
        {
            if (sid1 < 0 || sid2 < 0 || sid3 < 0 || sid1 + sid2 < sid3 || sid1 + sid3 < sid2 || sid3 + sid2 < sid1) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    class Factory
    {
        public Square GetSquare(double edg)
        {
            Polygon pro = new Square(edg);
            if (pro.legal()) return (Square)pro;
            return null;
        }
        public Rectangle GetRectangle(double len, double wid)
        {
            Polygon pro = new Rectangle(len,wid);
            if (pro.legal()) return (Rectangle)pro;
            return null;
        }

        public Triangle GetTriangle(double sid1, double sid2, double sid3)
        {
            Polygon pro = new Triangle(sid1, sid2, sid3);
            if (pro.legal()) return (Triangle)pro;
            return null;
        }

        public void RadomShape()
        {
            Polygon pro;
            Random r = new Random();
            int kind = r.Next(0, 3);
            switch (kind)
            {
                case 0:
                    do
                        pro = new Rectangle((double)(10 * r.NextDouble()), (double)(10 * r.NextDouble()));
                    while (pro == null);
                    pro.Show();
                    break;
                case 1:
                    do
                        pro = new Square((double)(10 * r.NextDouble()));
                    while (pro == null);
                    pro.Show();
                    break;
                case 2:
                    do
                        pro = new Triangle((double)(10 * r.NextDouble()), (double)(10 * r.NextDouble()), (double)(10 * r.NextDouble()));
                    while (pro == null);
                    pro.Show();
                    break;
            }
        }
    }
}
