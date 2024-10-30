using System;
using System.Windows.Forms;
using static OpenGL_Lab_2.OpenGL;


namespace OpenGL_Lab_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            renderControl1.Start();
        }

        private void horValue_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetHorValue((int)horValue.Value);

            renderControl1.Refresh();
        }

        private void verValue_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SetVerValue((int)verValue.Value);

            renderControl1.Refresh();
        }

        private void fillMode_CheckedChanged(object sender, EventArgs e)
        {
            renderControl1.SetPolygonMode(GL_FILL);
        }

        private void lineMode_CheckedChanged(object sender, EventArgs e)
        {
            renderControl1.SetPolygonMode(GL_LINE);
        }

        private void pointsMode_CheckedChanged(object sender, EventArgs e)
        {
            renderControl1.SetPolygonMode(GL_POINT);
        }

        private void smoothModel_CheckedChanged(object sender, EventArgs e)
        {
            renderControl1.SetShadeMode(GL_SMOOTH);
        }

        private void flatModel_CheckedChanged(object sender, EventArgs e)
        {
            renderControl1.SetShadeMode(GL_FLAT);
        }
    }
}
