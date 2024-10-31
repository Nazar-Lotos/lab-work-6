using System;
using System.Windows.Forms;

namespace lab_work_6
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(tbPyramidSide.Text);
                double h = double.Parse(tbPyramidHeight.Text);
                double r = double.Parse(tbSphereRadius.Text);

                Solid pyramid = new Pyramid(a, h);
                Solid sphere = new Sphere(r);

                double pyramidVolume = pyramid.GetVolume();
                double sphereVolume = sphere.GetVolume();

                tbPyramidVolume.Text = pyramidVolume.ToString("F2");
                tbSphereVolume.Text = sphereVolume.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення.");
            }
        }
    }
}
