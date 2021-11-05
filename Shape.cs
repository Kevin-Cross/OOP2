using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_class2
{
    public abstract class Shape
    {
        protected List<Point> _Vertices {get; set;}
        public virtual List<Point> Vertices
        { 
            get
            {
                return _Vertices;
            }
            set
            {
                _Vertices = value;
            }
        }
        public Shape()
        {
            
        }
        public Shape(List<Point> vertices)
        {
            Vertices = vertices;
        }
       
        public virtual double Perimeter()
        {
            //int cookies = this.Vertices[0].X;
            //int xxx = p.Vertices[0].X;
            //Console.WriteLine(this.Vertices.Count);
            double d = 0;
            for (int x = 1; x+1 <= this.Vertices.Count; x++)
            {
                d += Vertices[x].Distance(Vertices[x-1]);
                if (x + 1 == this.Vertices.Count)
                {
                    d += Vertices[x].Distance(Vertices[0]); 
                    
                }

            }

            return d;
        }
        public abstract double Area();


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Vertices.Count > 0)
            {
                foreach (Point p in Vertices)
                    sb.Append($"({p.X},{p.Y}),");
            }
            string ssb = sb.ToString();
            return ssb.Remove(ssb.Length - 1, 1);
           
        }


    }
}
