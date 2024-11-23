using System.Windows.Forms;
using static OpenGL_Lab_5.OpenGL;


namespace OpenGL_Lab_5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void segments_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetSegments((int)segments_numeric.Value);
        }

        private void fill_radioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetDrawMode(true, GLU_FILL);
        }

        private void line_radioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetDrawMode(false, GLU_LINE);
        }

        private void sphereRadius_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetSphereRadius((float)sphereRadius_numeric.Value);
        }

        private void coneRadius_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetConeRadius((float)coneRadius_numeric.Value);
        }

        private void coneHeight_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetConeHeight((float)coneHeight_numeric.Value);

            coneSlice_numeric.Maximum = coneHeight_numeric.Value;
        }

        private void coneSlice_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetConeSlice((float)coneSlice_numeric.Value);
        }

        private void partialDiskInnerRadius_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetPDInnerRadius((float)partialDiskInnerRadius_numeric.Value);
        }

        private void partialDiskOuterRadius_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetPDOuterRadius((float)partialDiskOuterRadius_numeric.Value);
        }

        private void partialDiskStartAngle_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetPDStartAngle((float)partialDiskStartAngle_numeric.Value);
        }

        private void partialDiskSweepAngle_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetPDSweepAngle((float)partialDiskSweepAngle_numeric.Value);
        }

        private void ortho_radioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetRenderMode(false);
        }

        private void perspective_radioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetRenderMode(true);
        }
    }
}
