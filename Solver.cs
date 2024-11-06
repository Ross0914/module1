using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Shapes3D;

namespace Solver
{
    public static class Solver
    {
        public static void Main(string[] args)
        {
            string filepath = args[0];
            double total = 0;
            List<Shape3D> shapeList = new List<Shape3D>();

            foreach (string line in File.ReadLines(filepath))
            {
                string[] lineData = line.Split(',');

                switch (lineData[0])
                {
                    case "cuboid":
                        double width = double.Parse(lineData[1]);
                        double height = double.Parse(lineData[2]);
                        double depth = double.Parse(lineData[3]);
                        shapeList.Add(new Cuboid(width, height, depth));
                        break;

                    case "cube":
                        double sideLength = double.Parse(lineData[1]);
                        shapeList.Add(new Cube(sideLength));
                        break;

                    case "cylinder":
                        double radius = double.Parse(lineData[1]);
                        double cylHeight = double.Parse(lineData[2]);
                        shapeList.Add(new Cylinder(radius, cylHeight));
                        break;

                    case "sphere":
                        double sphereRadius = double.Parse(lineData[1]);
                        shapeList.Add(new Sphere(sphereRadius));
                        break;

                    case "prism":
                        double prismSide = double.Parse(lineData[1]);
                        int faces = int.Parse(lineData[2]);
                        double prismHeight = double.Parse(lineData[3]);
                        shapeList.Add(new Prism(prismSide, faces, prismHeight));
                        break;

                    case "area":
                        int scaleArea = int.Parse(lineData[1]);
                        foreach (var shape in shapeList)
                        {
                            total += shape.SurfaceArea * scaleArea;
                        }
                        shapeList.Clear();
                        break;

                    case "volume":
                        int scaleVolume = int.Parse(lineData[1]);
                        foreach (var shape in shapeList)
                        {
                            total += shape.Volume * scaleVolume;
                        }
                        shapeList.Clear();
                        break;
                }
            }

            Console.WriteLine($"The sum of measurements is {total.ToString("N2", CultureInfo.InvariantCulture)}");
        }
    }
}

