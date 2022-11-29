using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Models
{
    internal class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static bool operator != (Point3D operand1, Point3D operand2)
        {
            return operand1.X != operand2.X && operand1.Y != operand2.Y && operand1.Z != operand2.Z;
        }

        public static bool operator == (Point3D operand1, Point3D operand2)
        {
            return operand1.X == operand2.X && operand1.Y == operand2.Y && operand1.Z == operand2.Z;
        }

        public static Point3D operator + (Point3D operand1, Point3D operand2)
        {
            return new Point3D
            {
                X = operand1.X + operand2.X,
                Y = operand1.Y + operand2.Y,
                Z = operand1.Z + operand2.Z
            };
        }

        public static Point3D operator - (Point3D operand1, Point3D operand2)
        {
            return new Point3D
            {
                X = operand1.X - operand2.X,
                Y = operand1.Y - operand2.Y,
                Z = operand1.Z - operand2.Z
            };
        }

        public static Point3D operator * (int scalar, Point3D operand1)
        {
            return new Point3D
            {
                X = operand1.X * scalar,
                Y = operand1.Y * scalar,
                Z = operand1.Z * scalar
            };
        }

        public static Point3D operator / (Point3D operand1, int scalar)
        {
            return new Point3D
            {
                X = operand1.X / scalar,
                Y = operand1.Y / scalar,
                Z = operand1.Z / scalar
            };
        }
    }
}
