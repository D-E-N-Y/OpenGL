using System;
using System.Diagnostics;
using System.Windows.Forms;
using static OpenGL_Lab_3.OpenGL;


namespace OpenGL_Lab_3
{
    public partial class MainForm : Form
    {
        private float step = 0.1f;

        public MainForm()
        {
            InitializeComponent();

            // set mix max value for X numerics
            Xmax_numeric.Minimum = Xmin_numeric.Value + (decimal)step;
            Xmin_numeric.Maximum = Xmax_numeric.Value - (decimal)step;
        }

        private void Xmin_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            Xmax_numeric.Minimum = Xmin_numeric.Value + (decimal)step;

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    renderControl1.SetXmin((float)Xmin_numeric.Value);
                    break;

                case 1:
                    renderControl2.SetXmin((float)Xmin_numeric.Value);
                    break;
            }
        }

        private void Xmax_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            Xmin_numeric.Maximum = Xmax_numeric.Value - (decimal)step;

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    renderControl1.SetXmax((float)Xmax_numeric.Value);
                    break;

                case 1:
                    renderControl2.SetXmax((float)Xmax_numeric.Value);
                    break;
            }
        }

        private void Ymin_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    renderControl1.SetYmin((float)Ymin_numeric.Value);
                    break;

                case 1:
                    renderControl2.SetYmin((float)Ymin_numeric.Value);
                    break;
            }
        }

        private void Ymax_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    renderControl1.SetYmax((float)Ymax_numeric.Value);
                    break;

                case 1:
                    renderControl2.SetYmax((float)Ymax_numeric.Value);
                    break;
            }
        }

        private void Points_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    renderControl1.SetPoints((int)Points_numeric.Value);
                    break;

                case 1:
                    renderControl2.SetPoints((int)Points_numeric.Value);
                    break;
            }
        }

        private void Step_numeric_ValueChanged(object sender, System.EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    renderControl1.SetStep((float)Step_numeric.Value);
                    break;

                case 1:
                    renderControl2.SetStep((float)Step_numeric.Value);
                    break;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    renderControl1.Start(Ymin_numeric,
                                Ymax_numeric,
                                tabControl1.SelectedIndex,
                                autoSizeY_checkBox.Checked,
                                (float)(Xmin_numeric.Value),
                                (float)(Xmax_numeric.Value),
                                (float)(Ymin_numeric.Value),
                                (float)(Ymax_numeric.Value),
                                0.2f,
                                (float)(Step_numeric.Value),
                                (int)(Points_numeric.Value));
                    break;

                case 1:
                    renderControl2.Start(Ymin_numeric,
                                Ymax_numeric,
                                tabControl1.SelectedIndex,
                                autoSizeY_checkBox.Checked,
                                (float)(Xmin_numeric.Value),
                                (float)(Xmax_numeric.Value),
                                (float)(Ymin_numeric.Value),
                                (float)(Ymax_numeric.Value),
                                0.2f,
                                (float)(Step_numeric.Value),
                                (int)(Points_numeric.Value));
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            renderControl1.Start(Ymin_numeric,
                                Ymax_numeric,
                                tabControl1.SelectedIndex,
                                autoSizeY_checkBox.Checked,
                                (float)(Xmin_numeric.Value),
                                (float)(Xmax_numeric.Value),
                                (float)(Ymin_numeric.Value),
                                (float)(Ymax_numeric.Value),
                                0.2f,
                                (float)(Step_numeric.Value),
                                (int)(Points_numeric.Value));
        }

        private void autoSizeY_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    renderControl1.SetAutoSizeY(autoSizeY_checkBox.Checked);
                    break;

                case 1:
                    renderControl2.SetAutoSizeY(autoSizeY_checkBox.Checked);
                    break;
            }

            if (autoSizeY_checkBox.Checked)
            {
                Ymin_numeric.Enabled = false;
                Ymax_numeric.Enabled = false;

                label5.Enabled = false;
                label4.Enabled = false;
            }
            else
            {
                Ymin_numeric.Enabled = true;
                Ymax_numeric.Enabled = true;

                label5.Enabled = true;
                label4.Enabled = true;
            }
        }
    }
}
