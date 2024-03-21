using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planetario4
{
    internal class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector() { }
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Modulo()
        {
            return Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        public static Vector Parse(string str)
        {
            string[] componenti = str.Split(',');
            return new Vector(double.Parse(componenti[0]), double.Parse(componenti[1]));
        }

        public bool TryParse(string str, out Vector vettore)
        {
            try
            {
                vettore = Vector.Parse(str);
                return true;
            }
            catch
            {
                vettore = null;
                return false;
            }
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }
        public static double operator *(Vector v1, Vector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }
        public static Vector operator *(Vector v1, double a)
        {
            return new Vector(v1.X * a, v1.Y * a);
        }
        public static Vector operator *(double a, Vector v1)
        {
            return new Vector(v1.X * a, v1.Y * a);
        }
        public static Vector operator /(Vector v1, double a)
        {
            return new Vector(v1.X / a, v1.Y / a);
        }
        public static Vector operator -(Vector v1)
        {
            return new Vector(-v1.X, -v1.Y);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            if (ReferenceEquals(v1, null))
                return object.ReferenceEquals(v2, null);
            else if (ReferenceEquals(v2, null))
                return false;
            else
                return v1.X == v2.X && v1.Y == v2.Y;
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            return !Equals(v1, v2);
        }

        public Vector Versore()
        {
            return this / this.Modulo();
        }
    }
}
