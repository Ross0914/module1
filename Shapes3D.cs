namespace Shapes3D
{
    public abstract class Shape3D
    {
        public abstract double SurfaceArea { get; }
        public abstract double Volume { get; }
    }

    public class Cuboid : Shape3D
    {
        public double Width { get; }
        public double Height { get; }
        public double Depth { get; }
        
        public override double SurfaceArea { get; }
        public override double Volume { get; }

        public Cuboid(double width, double height, double depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
            SurfaceArea = 2 * (width * height + width * depth + height * depth);
            Volume = width * height * depth;
        }
    }

    public class Cube : Cuboid
    {
        public Cube(double sideLength) : base(sideLength, sideLength, sideLength) { }
    }

    public class Cylinder : Shape3D
    {
        public double Radius { get; }
        public double Height { get; }
        
        public override double SurfaceArea { get; }
        public override double Volume { get; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
            SurfaceArea = 2 * Math.PI * radius * (radius + height);
            Volume = Math.PI * Math.Pow(radius, 2) * height;
        }
    }

    public class Sphere : Shape3D
    {
        public double Radius { get; }
        
        public override double SurfaceArea { get; }
        public override double Volume { get; }

        public Sphere(double radius)
        {
            Radius = radius;
            SurfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
            Volume = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
        }
    }

    public class Prism : Shape3D
    {
        public double SideLength { get; }
        public int Faces { get; }
        public double Height { get; }
        
        public override double SurfaceArea { get; }
        public override double Volume { get; }

        public Prism(double sideLength, int faces, double height)
        {
            SideLength = sideLength;
            Faces = faces;
            Height = height;
            SurfaceArea = (Faces * SideLength * Height) + (2 * (0.25 * Faces * Math.Pow(SideLength, 2)) / Math.Tan(Math.PI / Faces));
            Volume = (0.25 * Faces * Math.Pow(SideLength, 2) * Height) / Math.Tan(Math.PI / Faces);
       
