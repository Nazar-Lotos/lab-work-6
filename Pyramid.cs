namespace lab_work_6
{
    public class Pyramid : Solid
    {
        public double A { get; set; }
        public double H { get; set; }

        public Pyramid(double a, double h)
        {
            A = a;
            H = h;
        }

        public double GetVolume()
        {
            return (1.0 / 3.0) * A * A * H;
        }
    }
}
