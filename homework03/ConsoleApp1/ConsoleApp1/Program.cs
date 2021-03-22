using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test {
        public static void Main()
        {
            Shape[] shapes =
            {
                new Square(5,"正方形"),
                new Rectangle(4,5,"矩形"),
                new Circle(3,"圆"),
                new Triangle(4,5,6,"三角形")
            };
            foreach(Shape s in shapes)
            {
                System.Console.WriteLine(s.Print);
            }
        }
    }
    
    //抽象类:形状
    public abstract class Shape
    {
        private string myId;
        public Shape(string s) { Id = s; }

        public string Id
        {
            get { return myId; }
            set { myId = value; }
        }

        public abstract double Area
        {
            get;
        }

        public abstract bool Iflegal();

        public string Print
        {
            get { return Id + "面积为" + string.Format("{0:F2}", Area); }
        } 
    }

    //正方形类
    public class Square : Shape
    {
        private int mySide;
        public Square(int side,string id) : base(id)
        {
            mySide = side;
        }            
         public override double Area
        {
            get { return mySide * mySide; }
        }
        public override bool Iflegal()
        {
            return mySide > 0 ;
        }
    }

    //矩形类
    public class Rectangle : Shape
    {
        private int myLength;
        private int myWidth;

        public Rectangle(int length,int width,string id) : base(id)
        {
            myLength = length;
            myWidth = width;
        }
        public override double Area
        {
            get { return myLength * myWidth; }
        }
        public override bool Iflegal()
        {
            return myLength > 0 && myWidth > 0;
        }
    }

    //圆类
    public class Circle : Shape
    {
        private int myRadius;
        private const double pi = 3.14;
        public Circle(int radius,string id) : base(id)
        {
            myRadius = radius;
        }
        public override double Area
        {
            get { return pi * myRadius * myRadius; }
        }
        public override bool Iflegal()
        {
            return myRadius > 0;
        }
    }

    //三角形类
    public class Triangle : Shape
    {
        private int mySide1;
        private int mySide2;
        private int mySide3;
        public Triangle(int side1, int side2, int side3, string id) : base(id)
        {
            mySide1 = side1;
            mySide2 = side2;
            mySide3 = side3;
        }
        public override double Area
        {
            get
            {
                double p = (mySide1 + mySide2 + mySide3) / 2;
                return Math.Sqrt(p*(p - mySide1)*(p - mySide2)*(p - mySide3));
            }
        }
        public override bool Iflegal()
        {
            return mySide1 > 0 && mySide1 > 0 && mySide3 > 0 && mySide1 + mySide2 > mySide3 && mySide1 + mySide3 > mySide2;
        }
    }
}
