using System.Windows.Forms;
using static OpenGL_Lab_4.OpenGL;


namespace OpenGL_Lab_4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void curve_comboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetDrawCurve(curve_comboBox.SelectedIndex);

            switch (curve_comboBox.SelectedIndex)
            {
                case 0:
                    hyperbole_panel.Enabled = false;

                    circle_panel.Enabled = true;
                    line_panel.Enabled = true;
                    break;

                case 1:
                    circle_panel.Enabled = false;
                    line_panel.Enabled = false;

                    hyperbole_panel.Enabled = true;
                    break;
            }
        }

        private void drawLine_button_Click(object sender, System.EventArgs e)
        {
            renderControl1.SetPointsLine(
                [(float)point1_x_numeric.Value, (float)point1_y_numeric.Value],
                [(float)point2_x_numeric.Value, (float)point2_y_numeric.Value]);
        }

        private void radius_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetRadius((float)radius_numeric.Value);
        }

        private void hyp_a_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetHypA((float)hyp_a_numeric.Value);
        }

        private void hyp_b_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetHypB((float)hyp_b_numeric.Value);
        }
    }
}
