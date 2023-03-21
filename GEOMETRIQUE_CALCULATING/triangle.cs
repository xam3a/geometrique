using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEOMETRIQUE_CALCULATING
{
    public partial class triangle : Form
    {
        double perimeter, area;
        public triangle()
        {
            InitializeComponent();
        }

        private void HomePage_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void triangle_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome", "https://byjus.com/maths/triangles/");
        }

        private void other_shapes(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();

            decagon newDecagon = new decagon();
            heptagon newHeptagon = new heptagon();
            hexagon newHexagon = new hexagon();
            nonagon newNonagon = new nonagon();
            octagon newOctagon = new octagon();
            parallelogram newParallelogram = new parallelogram();
            pentagon newPentagon = new pentagon();
            rhombus newRhombus = new rhombus();
            square newSquare = new square();
            trapezium newTrapezium = new trapezium();
            kite newKite = new kite();

            switch (pictureBox.Name)
            {
                case "decagon":
                    this.Hide();
                    newDecagon.Show();
                    break;
                case "heptagon":
                    this.Hide();
                    newHeptagon.Show();
                    break;
                case "hexagon":
                    this.Hide();
                    newHexagon.Show();
                    break;
                case "kite":
                    this.Hide();
                    newKite.Show();
                    break;
                case "nonagon":
                    this.Hide();
                    newNonagon.Show();
                    break;
                case "octagon":
                    this.Hide();
                    newOctagon.Show();
                    break;
                case "parallelogram":
                    this.Hide();
                    newParallelogram.Show();
                    break;
                case "pentagon":
                    this.Hide();
                    newPentagon.Show();
                    break;
                case "rhombus":
                    this.Hide();
                    newRhombus.Show();
                    break;
                case "square":
                    this.Hide();
                    newSquare.Show();
                    break;
                case "trapezium":
                    this.Hide();
                    newTrapezium.Show();
                    break;
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            perimeter = Double.Parse(side2_txtbox.Text) + Double.Parse(base_txtbox.Text) + Double.Parse(side1_txtbox.Text);
            Perimeter_txtbox.Text = perimeter.ToString();

            area = (Double.Parse(base_txtbox.Text) * Double.Parse(heigth_txtbox.Text)) / 2;
            Area_txtbox.Text = area.ToString();


        }
    }
}
