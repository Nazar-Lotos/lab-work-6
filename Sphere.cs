using System;
namespace lab_work_6
{
    public class Sphere : Solid
    {
        public double R { get; set; }

        public Sphere(double r)
        {
            R = r;
        }

        public double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
        }
    }
}
