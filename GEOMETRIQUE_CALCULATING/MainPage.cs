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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void decagon_Click(object sender, EventArgs e)
        {
            this.Hide();
            decagon newDecagon = new decagon();
            newDecagon.Show();
        }

        private void heptagon_Click(object sender, EventArgs e)
        {
            this.Hide();
            heptagon newHeptagon = new heptagon();
            newHeptagon.Show();
        }

        private void hexagon_Click(object sender, EventArgs e)
        {
            this.Hide();
            hexagon newHexagon = new hexagon();
            newHexagon.Show();
        }

        private void kite_Click(object sender, EventArgs e)
        {
            this.Hide();
            kite newKite = new kite();
            newKite.Show();
        }

        private void nonagon_Click(object sender, EventArgs e)
        {
            this.Hide();
            nonagon newNonagon = new nonagon();
            newNonagon.Show();
        }

        private void octagon_Click(object sender, EventArgs e)
        {
            this.Hide();
            octagon newOctagon = new octagon();
            newOctagon.Show();
        }

        private void parallelogram_Click(object sender, EventArgs e)
        {
            this.Hide();
            parallelogram newParallelogram = new parallelogram();
            newParallelogram.Show();
        }

        private void pentagon_Click(object sender, EventArgs e)
        {
            this.Hide();
            pentagon newPentagon = new pentagon();
            newPentagon.Show();
        }

        private void rhombus_Click(object sender, EventArgs e)
        {
            this.Hide();
            rhombus newRHombus = new rhombus();
            newRHombus.Show();
        }

        private void trapezium_Click(object sender, EventArgs e)
        {
            this.Hide();
            trapezium newTrapezium = new trapezium();
            newTrapezium.Show();
        }

        private void square_Click(object sender, EventArgs e)
        {
            this.Hide();
            square newSquare = new square();
            newSquare.Show();
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            this.Hide();
            triangle newTriangle = new triangle();
            newTriangle.Show();
        }
    }
}
