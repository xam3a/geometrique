using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GEOMETRIQUE_CALCULATING {
	public partial class triangle : Form {
		private double _perimeter, _area;
		public triangle() {
			InitializeComponent();
		}

		private void HomePage_btn_Click(object sender, EventArgs e) {
			Hide();
			var newMainPage = new MainPage();
			newMainPage.Show();
		}

		private void triangle_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start("Chrome", "https://byjus.com/maths/triangles/");
		}

		private void other_shapes(object sender, EventArgs e) {
			var newPictureBox = (PictureBox) sender;

			switch (newPictureBox.Name) {
				case "decagon":
					Hide();
					new decagon().Show();
					break;
				case "heptagon":
					Hide();
					new heptagon().Show();
					break;
				case "hexagon":
					Hide();
					new hexagon().Show();
					break;
				case "kite":
					Hide();
					new kite().Show();
					break;
				case "nonagon":
					Hide();
					new nonagon().Show();
					break;
				case "octagon":
					Hide();
					new octagon().Show();
					break;
				case "parallelogram":
					Hide();
					new parallelogram().Show();
					break;
				case "pentagon":
					Hide();
					new pentagon().Show();
					break;
				case "rhombus":
					Hide();
					new rhombus().Show();
					break;
				case "square":
					Hide();
					new square().Show();
					break;
				case "trapezium":
					Hide();
					new trapezium().Show();
					break;
			}
		}

		private void submit_btn_Click(object sender, EventArgs e) {
			_perimeter = double.Parse(side2_txtbox.Text) + double.Parse(base_txtbox.Text) +
			            double.Parse(side1_txtbox.Text);
			Perimeter_txtbox.Text = _perimeter.ToString();

			_area = (double.Parse(base_txtbox.Text) * double.Parse(heigth_txtbox.Text)) / 2;
			Area_txtbox.Text = _area.ToString();


		}
	}
}