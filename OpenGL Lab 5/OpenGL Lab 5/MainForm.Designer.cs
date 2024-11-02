
namespace OpenGL_Lab_5
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            panel1 = new System.Windows.Forms.Panel();
            segments_numeric = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            line_radioButton = new System.Windows.Forms.RadioButton();
            fill_radioButton = new System.Windows.Forms.RadioButton();
            label4 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            sphereRadius_numeric = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            coneSlice_numeric = new System.Windows.Forms.NumericUpDown();
            label11 = new System.Windows.Forms.Label();
            coneHeight_numeric = new System.Windows.Forms.NumericUpDown();
            label10 = new System.Windows.Forms.Label();
            coneRadius_numeric = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            partialDiskSweepAngle_numeric = new System.Windows.Forms.NumericUpDown();
            label14 = new System.Windows.Forms.Label();
            partialDiskStartAngle_numeric = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            partialDiskOuterRadius_numeric = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            partialDiskInnerRadius_numeric = new System.Windows.Forms.NumericUpDown();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)segments_numeric).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sphereRadius_numeric).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coneSlice_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coneHeight_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coneRadius_numeric).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)partialDiskSweepAngle_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partialDiskStartAngle_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partialDiskOuterRadius_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partialDiskInnerRadius_numeric).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            renderControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(780, 726);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 65001;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            panel1.Controls.Add(segments_numeric);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(798, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(303, 102);
            panel1.TabIndex = 1;
            // 
            // segments_numeric
            // 
            segments_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            segments_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            segments_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            segments_numeric.ForeColor = System.Drawing.Color.White;
            segments_numeric.Location = new System.Drawing.Point(147, 56);
            segments_numeric.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            segments_numeric.Name = "segments_numeric";
            segments_numeric.Size = new System.Drawing.Size(140, 26);
            segments_numeric.TabIndex = 2;
            segments_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            segments_numeric.Value = new decimal(new int[] { 15, 0, 0, 0 });
            segments_numeric.ValueChanged += segments_numeric_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(39, 56);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 22);
            label2.TabIndex = 2;
            label2.Text = "segments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(68, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(149, 32);
            label1.TabIndex = 2;
            label1.Text = "Acccuracy";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            panel2.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            panel2.Controls.Add(line_radioButton);
            panel2.Controls.Add(fill_radioButton);
            panel2.Controls.Add(label4);
            panel2.Location = new System.Drawing.Point(798, 123);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(303, 121);
            panel2.TabIndex = 3;
            // 
            // line_radioButton
            // 
            line_radioButton.AutoSize = true;
            line_radioButton.BackColor = System.Drawing.Color.Transparent;
            line_radioButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            line_radioButton.ForeColor = System.Drawing.Color.White;
            line_radioButton.Location = new System.Drawing.Point(108, 86);
            line_radioButton.Name = "line_radioButton";
            line_radioButton.Size = new System.Drawing.Size(68, 26);
            line_radioButton.TabIndex = 4;
            line_radioButton.Text = "line";
            line_radioButton.UseVisualStyleBackColor = false;
            line_radioButton.CheckedChanged += line_radioButton_CheckedChanged;
            // 
            // fill_radioButton
            // 
            fill_radioButton.AutoSize = true;
            fill_radioButton.BackColor = System.Drawing.Color.Transparent;
            fill_radioButton.Checked = true;
            fill_radioButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            fill_radioButton.ForeColor = System.Drawing.Color.White;
            fill_radioButton.Location = new System.Drawing.Point(108, 54);
            fill_radioButton.Name = "fill_radioButton";
            fill_radioButton.Size = new System.Drawing.Size(68, 26);
            fill_radioButton.TabIndex = 3;
            fill_radioButton.TabStop = true;
            fill_radioButton.Text = "fill";
            fill_radioButton.UseVisualStyleBackColor = false;
            fill_radioButton.CheckedChanged += fill_radioButton_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(83, 10);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(119, 32);
            label4.TabIndex = 2;
            label4.Text = "Drawing";
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            panel3.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            panel3.Controls.Add(sphereRadius_numeric);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Location = new System.Drawing.Point(798, 250);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(303, 99);
            panel3.TabIndex = 3;
            // 
            // sphereRadius_numeric
            // 
            sphereRadius_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            sphereRadius_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            sphereRadius_numeric.DecimalPlaces = 1;
            sphereRadius_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            sphereRadius_numeric.ForeColor = System.Drawing.Color.White;
            sphereRadius_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            sphereRadius_numeric.Location = new System.Drawing.Point(147, 55);
            sphereRadius_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            sphereRadius_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            sphereRadius_numeric.Name = "sphereRadius_numeric";
            sphereRadius_numeric.Size = new System.Drawing.Size(140, 26);
            sphereRadius_numeric.TabIndex = 2;
            sphereRadius_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            sphereRadius_numeric.Value = new decimal(new int[] { 35, 0, 0, 65536 });
            sphereRadius_numeric.ValueChanged += sphereRadius_numeric_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(39, 54);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 22);
            label3.TabIndex = 2;
            label3.Text = "radius";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(98, 11);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(104, 32);
            label5.TabIndex = 2;
            label5.Text = "Sphere";
            // 
            // panel5
            // 
            panel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            panel5.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            panel5.Controls.Add(coneSlice_numeric);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(coneHeight_numeric);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(coneRadius_numeric);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Location = new System.Drawing.Point(798, 355);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(303, 166);
            panel5.TabIndex = 5;
            // 
            // coneSlice_numeric
            // 
            coneSlice_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            coneSlice_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            coneSlice_numeric.DecimalPlaces = 1;
            coneSlice_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            coneSlice_numeric.ForeColor = System.Drawing.Color.White;
            coneSlice_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            coneSlice_numeric.Location = new System.Drawing.Point(147, 121);
            coneSlice_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            coneSlice_numeric.Name = "coneSlice_numeric";
            coneSlice_numeric.Size = new System.Drawing.Size(140, 26);
            coneSlice_numeric.TabIndex = 5;
            coneSlice_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            coneSlice_numeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            coneSlice_numeric.ValueChanged += coneSlice_numeric_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(39, 120);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(60, 22);
            label11.TabIndex = 6;
            label11.Text = "slice";
            // 
            // coneHeight_numeric
            // 
            coneHeight_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            coneHeight_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            coneHeight_numeric.DecimalPlaces = 1;
            coneHeight_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            coneHeight_numeric.ForeColor = System.Drawing.Color.White;
            coneHeight_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            coneHeight_numeric.Location = new System.Drawing.Point(147, 89);
            coneHeight_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            coneHeight_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            coneHeight_numeric.Name = "coneHeight_numeric";
            coneHeight_numeric.Size = new System.Drawing.Size(140, 26);
            coneHeight_numeric.TabIndex = 3;
            coneHeight_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            coneHeight_numeric.Value = new decimal(new int[] { 4, 0, 0, 0 });
            coneHeight_numeric.ValueChanged += coneHeight_numeric_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(39, 88);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(70, 22);
            label10.TabIndex = 4;
            label10.Text = "height";
            // 
            // coneRadius_numeric
            // 
            coneRadius_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            coneRadius_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            coneRadius_numeric.DecimalPlaces = 1;
            coneRadius_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            coneRadius_numeric.ForeColor = System.Drawing.Color.White;
            coneRadius_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            coneRadius_numeric.Location = new System.Drawing.Point(147, 57);
            coneRadius_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            coneRadius_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            coneRadius_numeric.Name = "coneRadius_numeric";
            coneRadius_numeric.Size = new System.Drawing.Size(140, 26);
            coneRadius_numeric.TabIndex = 2;
            coneRadius_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            coneRadius_numeric.Value = new decimal(new int[] { 25, 0, 0, 65536 });
            coneRadius_numeric.ValueChanged += coneRadius_numeric_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(39, 56);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(70, 22);
            label8.TabIndex = 2;
            label8.Text = "radius";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(113, 13);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(74, 32);
            label9.TabIndex = 2;
            label9.Text = "Cone";
            // 
            // panel4
            // 
            panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            panel4.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            panel4.Controls.Add(partialDiskSweepAngle_numeric);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(partialDiskStartAngle_numeric);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(partialDiskOuterRadius_numeric);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(partialDiskInnerRadius_numeric);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Location = new System.Drawing.Point(798, 527);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(303, 211);
            panel4.TabIndex = 7;
            // 
            // partialDiskSweepAngle_numeric
            // 
            partialDiskSweepAngle_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            partialDiskSweepAngle_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            partialDiskSweepAngle_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            partialDiskSweepAngle_numeric.ForeColor = System.Drawing.Color.White;
            partialDiskSweepAngle_numeric.Location = new System.Drawing.Point(147, 164);
            partialDiskSweepAngle_numeric.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            partialDiskSweepAngle_numeric.Name = "partialDiskSweepAngle_numeric";
            partialDiskSweepAngle_numeric.Size = new System.Drawing.Size(140, 26);
            partialDiskSweepAngle_numeric.TabIndex = 7;
            partialDiskSweepAngle_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            partialDiskSweepAngle_numeric.Value = new decimal(new int[] { 90, 0, 0, 0 });
            partialDiskSweepAngle_numeric.ValueChanged += partialDiskSweepAngle_numeric_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = System.Drawing.Color.Transparent;
            label14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label14.ForeColor = System.Drawing.Color.White;
            label14.Location = new System.Drawing.Point(14, 163);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(120, 22);
            label14.TabIndex = 8;
            label14.Text = "sweep angle";
            // 
            // partialDiskStartAngle_numeric
            // 
            partialDiskStartAngle_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            partialDiskStartAngle_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            partialDiskStartAngle_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            partialDiskStartAngle_numeric.ForeColor = System.Drawing.Color.White;
            partialDiskStartAngle_numeric.Location = new System.Drawing.Point(147, 132);
            partialDiskStartAngle_numeric.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            partialDiskStartAngle_numeric.Name = "partialDiskStartAngle_numeric";
            partialDiskStartAngle_numeric.Size = new System.Drawing.Size(140, 26);
            partialDiskStartAngle_numeric.TabIndex = 5;
            partialDiskStartAngle_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            partialDiskStartAngle_numeric.Value = new decimal(new int[] { 180, 0, 0, 0 });
            partialDiskStartAngle_numeric.ValueChanged += partialDiskStartAngle_numeric_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(11, 131);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(120, 22);
            label6.TabIndex = 6;
            label6.Text = "start angle";
            // 
            // partialDiskOuterRadius_numeric
            // 
            partialDiskOuterRadius_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            partialDiskOuterRadius_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            partialDiskOuterRadius_numeric.DecimalPlaces = 1;
            partialDiskOuterRadius_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            partialDiskOuterRadius_numeric.ForeColor = System.Drawing.Color.White;
            partialDiskOuterRadius_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            partialDiskOuterRadius_numeric.Location = new System.Drawing.Point(147, 100);
            partialDiskOuterRadius_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            partialDiskOuterRadius_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            partialDiskOuterRadius_numeric.Name = "partialDiskOuterRadius_numeric";
            partialDiskOuterRadius_numeric.Size = new System.Drawing.Size(140, 26);
            partialDiskOuterRadius_numeric.TabIndex = 3;
            partialDiskOuterRadius_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            partialDiskOuterRadius_numeric.Value = new decimal(new int[] { 15, 0, 0, 65536 });
            partialDiskOuterRadius_numeric.ValueChanged += partialDiskOuterRadius_numeric_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(11, 99);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(130, 22);
            label7.TabIndex = 4;
            label7.Text = "outer radius";
            // 
            // partialDiskInnerRadius_numeric
            // 
            partialDiskInnerRadius_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            partialDiskInnerRadius_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            partialDiskInnerRadius_numeric.DecimalPlaces = 1;
            partialDiskInnerRadius_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            partialDiskInnerRadius_numeric.ForeColor = System.Drawing.Color.White;
            partialDiskInnerRadius_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            partialDiskInnerRadius_numeric.Location = new System.Drawing.Point(147, 68);
            partialDiskInnerRadius_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            partialDiskInnerRadius_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            partialDiskInnerRadius_numeric.Name = "partialDiskInnerRadius_numeric";
            partialDiskInnerRadius_numeric.Size = new System.Drawing.Size(140, 26);
            partialDiskInnerRadius_numeric.TabIndex = 2;
            partialDiskInnerRadius_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            partialDiskInnerRadius_numeric.Value = new decimal(new int[] { 45, 0, 0, 65536 });
            partialDiskInnerRadius_numeric.ValueChanged += partialDiskInnerRadius_numeric_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.White;
            label12.Location = new System.Drawing.Point(11, 67);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(130, 22);
            label12.TabIndex = 2;
            label12.Text = "inner radius";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.White;
            label13.Location = new System.Drawing.Point(57, 11);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(194, 32);
            label13.TabIndex = 2;
            label13.Text = "Partial disk";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            ClientSize = new System.Drawing.Size(1113, 750);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Lab 5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)segments_numeric).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sphereRadius_numeric).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coneSlice_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)coneHeight_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)coneRadius_numeric).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)partialDiskSweepAngle_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)partialDiskStartAngle_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)partialDiskOuterRadius_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)partialDiskInnerRadius_numeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown segments_numeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton line_radioButton;
        private System.Windows.Forms.RadioButton fill_radioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown sphereRadius_numeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown coneRadius_numeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown coneSlice_numeric;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown coneHeight_numeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown partialDiskStartAngle_numeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown partialDiskOuterRadius_numeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown partialDiskInnerRadius_numeric;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown partialDiskSweepAngle_numeric;
        private System.Windows.Forms.Label label14;
    }
}

