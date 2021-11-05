using System;
using System.Collections.Generic;
using System.Text;



namespace Lab2_class2
{
    public class Triangle : Shape
    {


        public override List<Point> Vertices
        {
            get
            {
                return _Vertices;
            }
            set
            {
                if (value.Count == 3)
                {
                    _Vertices = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Vertices", "3 Vertices for a triangle. Please provide 3 points");
                }
            }
        }


        public Triangle(List<Point> vertices) : base(vertices)
        {
        }

        public Triangle(Point v1, Point v2, Point v3) : base(new List<Point>() { v1, v2, v3 })
        {
        }

        public override double Area()
        {
            double s = this.Perimeter() / 2;
            double a = 0;
            double b = 0;
            double c = 0;
            for (int x = 1; x + 1 <= this.Vertices.Count; x++)
            {
                switch (x)
                {
                    case 1:
                        a = Math.Sqrt(Math.Pow(this.Vertices[x].X - this.Vertices[x - 1].X, 2) + Math.Pow(this.Vertices[x].Y - this.Vertices[x - 1].Y, 2));
                        break;
                    case 2:
                        b = Math.Sqrt(Math.Pow(this.Vertices[x].X - this.Vertices[x - 1].X, 2) + Math.Pow(this.Vertices[x].Y - this.Vertices[x - 1].Y, 2));
                        c = Math.Sqrt(Math.Pow(this.Vertices[x].X - this.Vertices[0].X, 2) + Math.Pow(this.Vertices[x].Y - this.Vertices[0].Y, 2));
                        break;
                }
            }
            //Console.WriteLine($"{a}, {b}, {c}");
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public virtual bool IsEquilateral()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            for (int x = 1; x + 1 <= this.Vertices.Count; x++)
            {
                switch (x)
                {
                    case 1:
                        a =Vertices[x].Distance(Vertices[x - 1]);
                        break;
                    case 2:
                        b = Vertices[x].Distance(Vertices[x - 1]); 
                        c = Vertices[x].Distance(Vertices[0]);
                        break;
                }
            }

            if(Utils.IsRelativelyEqual(a, b) && Utils.IsRelativelyEqual(a, c) && Utils.IsRelativelyEqual(c, b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool IsIsosceles()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            for (int x = 1; x + 1 <= this.Vertices.Count; x++)
            {
                switch (x)
                {
                    case 1:
                        a = Vertices[x].Distance(Vertices[x - 1]);
                        break;
                    case 2:
                        b = Vertices[x].Distance(Vertices[x - 1]);
                        c = Vertices[x].Distance(Vertices[0]);
                        break;
                }
            }
           
            if (Utils.IsRelativelyEqual(a, b) || Utils.IsRelativelyEqual(a, c) || Utils.IsRelativelyEqual(b, c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool IsScalene()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            for (int x = 1; x + 1 <= this.Vertices.Count; x++)
            {
                switch (x)
                {
                    case 1:
                        a = Vertices[x].Distance(Vertices[x - 1]);
                        break;
                    case 2:
                        b = Vertices[x].Distance(Vertices[x - 1]);
                        c = Vertices[x].Distance(Vertices[0]);
                        break;
                }
            }
             
            if (!Utils.IsRelativelyEqual(a, b) && !Utils.IsRelativelyEqual(a, c) && !Utils.IsRelativelyEqual(b, c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return $"Triangle: {base.ToString()}";
        }
    }
}
