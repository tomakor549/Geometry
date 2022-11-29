using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Models.R3
{
    internal class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3D Normalize()
        {
            return this / this.Length();
        }

        public static Vector3D Normalize(Vector3D vector3D)
        {
            return vector3D / vector3D.Length();
        }

        public double ScalarProduct(Vector3D vector3D)
        {
            return X * vector3D.X + Y * vector3D.Y + Z * vector3D.Z;
        }

        public static double ScalarProduct(Vector3D v, Vector3D u)
        {
            return v.ScalarProduct(u);
        }

        public Vector3D VectorProduct(Vector3D vector3D)
        {
            return new Vector3D
            {
                X = this.Y * vector3D.Z - this.Z * vector3D.Y,
                Y = -1 * this.X * vector3D.Z + this.Z * vector3D.X,
                Z = this.X * vector3D.Y - this.Y * vector3D.X,
            };
        }

        public static Vector3D VectorProduct(Vector3D v, Vector3D u)
        {
            return v.VectorProduct(u);
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(X,2)+ Math.Pow(Y, 2)+ Math.Pow(Z, 2));
        }

        public bool IsOrthonogal(Vector3D vector3D)
        {
            return ScalarProduct(vector3D) == 0;
        }

        public double Angle(Vector3D vector3D)
        {
            return Math.Acos(this.ScalarProduct(vector3D) / (this.Length() + vector3D.Length()));
        }

        public static bool operator !=(Vector3D operand1, Vector3D operand2)
        {
            return operand1.X != operand2.X && operand1.Y != operand2.Y && operand1.Z != operand2.Z;
        }

        public static bool operator ==(Vector3D operand1, Vector3D operand2)
        {
            return operand1.X == operand2.X && operand1.Y == operand2.Y && operand1.Z == operand2.Z;
        }

        public static Vector3D operator +(Vector3D operand1, Vector3D operand2)
        {
            return new Vector3D
            {
                X = operand1.X + operand2.X,
                Y = operand1.Y + operand2.Y,
                Z = operand1.Z + operand2.Z
            };
        }

        public static Vector3D operator *(Vector3D operand1, double scalar)
        {
            return new Vector3D
            {
                X = operand1.X * scalar,
                Y = operand1.Y * scalar,
                Z = operand1.Z * scalar
            };
        }

        public static Vector3D operator /(Vector3D operand1, double scalar)
        {
            return new Vector3D
            {
                X = operand1.X / scalar,
                Y = operand1.Y / scalar,
                Z = operand1.Z / scalar
            };
        }
    }
}
