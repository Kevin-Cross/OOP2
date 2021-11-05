using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_class2
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
        }



        public override List<Point> Vertices
        {
            get
            {
                return base.Vertices;
            }
            set
            {
                if(value.Count == 2 || value.Count == 4)
                {
                    base.Vertices = Normalize(value);
                    
                    
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Vertices", "You have entered an incorrect number of Points. The correct number of points is 2 or 4");
                }
            }
        }

        public override double Area()
        {
            return this.Width * this.Height;
        }
        private List<Point> Normalize(List<Point> input)
        {
            var bounds = Utils.GetBoundingBox(input);
            Point p1 = new Point();
            Point p2 = new Point();
            Point p3 = new Point();
            Point p4 = new Point();

                p1.Y = (int)bounds.Item4;
                p1.X = (int)bounds.Item1;
                p2.Y = (int)bounds.Item4;
                p2.X = (int)bounds.Item3;
                p3.Y = (int)bounds.Item2;
                p3.X = (int)bounds.Item3;
                p4.Y = (int)bounds.Item2;
                p4.X = (int)bounds.Item1;
            
            List<Point> p = new List<Point>();
            p.Add(p1);
            p.Add(p2);
            p.Add(p3);
            p.Add(p4);
            return p;

        }
        public double Width
        {
            get
            {
                var u =  Utils.GetBoundingBox(this.Vertices).Item3 - Utils.GetBoundingBox(this.Vertices).Item1;
                return u;
            }
        }
        public double Height
        {
            get
            {
                var u = Utils.GetBoundingBox(this.Vertices).Item4 - Utils.GetBoundingBox(this.Vertices).Item2;
                return u;
            }
        }
        public Rectangle(List<Point> vertices)
        {
            Vertices = vertices;
        }

        public Rectangle(Point v1, Point v2)
        {
            List<Point> p = new List<Point> { v1, v2 };
            Vertices = p;
        }

        public Rectangle(Point v1, Point v2, Point v3, Point v4)
        {
            List<Point> p = new List<Point> { v1, v2, v3, v4 };
            Vertices = p;
        }
        public bool IsSquare()
        {
            if(this.Width == this.Height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Triangle> ToTriangles()
        {
            Point a = new Point(this.Vertices[0].X, this.Vertices[0].Y);
            Point b = new Point(this.Vertices[1].X, this.Vertices[1].Y);
            Point c = new Point(this.Vertices[2].X, this.Vertices[2].Y);
            Point d = new Point(this.Vertices[3].X, this.Vertices[3].Y);

            Triangle t1 = new Triangle(a,b,c);
            Triangle t2 = new Triangle(c,d,a);
            List<Triangle> tl1 = new List<Triangle>();
            tl1.Add(t1);
            tl1.Add(t2);
            return tl1;
        }
        public override string ToString()
        {
            return $"Rectangle: {base.ToString()}";
        }
    }
}

