﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = PointLib.Point;

namespace LabOneFormsApp
{

    [Serializable]
    public class Point3D : Point
    {
        public int Z { get; set; }
        public Point3D() : base()
        {
            var rnd = new Random();
            Z = rnd.Next(10);
        }
        public Point3D(int x, int y, int z) : base(x, y) 
        { 

            this.Z = z; 
        }
        public override double Metric()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public override string ToString()
        {
            return string.Format($"(x = {X} , y = {Y}, z = {Z})");
        }
    }

    [Serializable]
    public class PointWrapper : Point3D
    {
        public int Z_copy { get; set; }
        public PointWrapper(int x, int y, int z) : base(x, y, z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Z_copy = z;
        }
    }

}
