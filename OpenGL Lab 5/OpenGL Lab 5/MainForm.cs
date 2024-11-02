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
    }
}
