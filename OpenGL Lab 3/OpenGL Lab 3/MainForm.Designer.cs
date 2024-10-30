
namespace OpenGL_Lab_3
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
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            Xmax_numeric = new System.Windows.Forms.NumericUpDown();
            Xmin_numeric = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            autoSizeY_checkBox = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            Ymax_numeric = new System.Windows.Forms.NumericUpDown();
            Ymin_numeric = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
            Points_numeric = new System.Windows.Forms.NumericUpDown();
            label9 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            label10 = new System.Windows.Forms.Label();
            Step_numeric = new System.Windows.Forms.NumericUpDown();
            label11 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage2 = new System.Windows.Forms.TabPage();
            renderControl2 = new RenderControl();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Xmax_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Xmin_numeric).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Ymax_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ymin_numeric).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Points_numeric).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Step_numeric).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            renderControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(3, 3);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(629, 586);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 65001;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            panel1.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Xmax_numeric);
            panel1.Controls.Add(Xmin_numeric);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(661, 58);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(228, 151);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(12, 102);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 22);
            label3.TabIndex = 4;
            label3.Text = "X max";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(12, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 22);
            label2.TabIndex = 3;
            label2.Text = "X min";
            // 
            // Xmax_numeric
            // 
            Xmax_numeric.Anchor = System.Windows.Forms.AnchorStyles.Right;
            Xmax_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            Xmax_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Xmax_numeric.DecimalPlaces = 1;
            Xmax_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Xmax_numeric.ForeColor = System.Drawing.Color.White;
            Xmax_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            Xmax_numeric.Location = new System.Drawing.Point(78, 103);
            Xmax_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            Xmax_numeric.Name = "Xmax_numeric";
            Xmax_numeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Xmax_numeric.Size = new System.Drawing.Size(120, 26);
            Xmax_numeric.TabIndex = 2;
            Xmax_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Xmax_numeric.Value = new decimal(new int[] { 3, 0, 0, 0 });
            Xmax_numeric.ValueChanged += Xmax_numeric_ValueChanged;
            // 
            // Xmin_numeric
            // 
            Xmin_numeric.Anchor = System.Windows.Forms.AnchorStyles.Right;
            Xmin_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            Xmin_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Xmin_numeric.DecimalPlaces = 1;
            Xmin_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Xmin_numeric.ForeColor = System.Drawing.Color.White;
            Xmin_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            Xmin_numeric.Location = new System.Drawing.Point(78, 59);
            Xmin_numeric.Maximum = new decimal(new int[] { 1, 0, 0, -2147418112 });
            Xmin_numeric.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            Xmin_numeric.Name = "Xmin_numeric";
            Xmin_numeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Xmin_numeric.Size = new System.Drawing.Size(120, 26);
            Xmin_numeric.TabIndex = 1;
            Xmin_numeric.Tag = "";
            Xmin_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Xmin_numeric.Value = new decimal(new int[] { 3, 0, 0, int.MinValue });
            Xmin_numeric.ValueChanged += Xmin_numeric_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(34, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(164, 32);
            label1.TabIndex = 0;
            label1.Text = "X interval";
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            panel2.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            panel2.Controls.Add(autoSizeY_checkBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Ymax_numeric);
            panel2.Controls.Add(Ymin_numeric);
            panel2.Controls.Add(label6);
            panel2.Location = new System.Drawing.Point(661, 215);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(228, 188);
            panel2.TabIndex = 5;
            // 
            // autoSizeY_checkBox
            // 
            autoSizeY_checkBox.AutoSize = true;
            autoSizeY_checkBox.BackColor = System.Drawing.Color.Transparent;
            autoSizeY_checkBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            autoSizeY_checkBox.ForeColor = System.Drawing.Color.White;
            autoSizeY_checkBox.Location = new System.Drawing.Point(22, 59);
            autoSizeY_checkBox.Name = "autoSizeY_checkBox";
            autoSizeY_checkBox.Size = new System.Drawing.Size(139, 26);
            autoSizeY_checkBox.TabIndex = 5;
            autoSizeY_checkBox.Text = "auto size Y";
            autoSizeY_checkBox.UseVisualStyleBackColor = false;
            autoSizeY_checkBox.CheckedChanged += autoSizeY_checkBox_CheckedChanged;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(12, 147);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 22);
            label4.TabIndex = 4;
            label4.Text = "Y max";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(12, 104);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 22);
            label5.TabIndex = 3;
            label5.Text = "Y min";
            // 
            // Ymax_numeric
            // 
            Ymax_numeric.Anchor = System.Windows.Forms.AnchorStyles.Right;
            Ymax_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            Ymax_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Ymax_numeric.DecimalPlaces = 1;
            Ymax_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Ymax_numeric.ForeColor = System.Drawing.Color.White;
            Ymax_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            Ymax_numeric.Location = new System.Drawing.Point(78, 148);
            Ymax_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            Ymax_numeric.Name = "Ymax_numeric";
            Ymax_numeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Ymax_numeric.Size = new System.Drawing.Size(120, 26);
            Ymax_numeric.TabIndex = 2;
            Ymax_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Ymax_numeric.Value = new decimal(new int[] { 3, 0, 0, 0 });
            Ymax_numeric.ValueChanged += Ymax_numeric_ValueChanged;
            // 
            // Ymin_numeric
            // 
            Ymin_numeric.Anchor = System.Windows.Forms.AnchorStyles.Right;
            Ymin_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            Ymin_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Ymin_numeric.DecimalPlaces = 1;
            Ymin_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Ymin_numeric.ForeColor = System.Drawing.Color.White;
            Ymin_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            Ymin_numeric.Location = new System.Drawing.Point(78, 104);
            Ymin_numeric.Maximum = new decimal(new int[] { 1, 0, 0, -2147418112 });
            Ymin_numeric.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            Ymin_numeric.Name = "Ymin_numeric";
            Ymin_numeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Ymin_numeric.Size = new System.Drawing.Size(120, 26);
            Ymin_numeric.TabIndex = 1;
            Ymin_numeric.Tag = "";
            Ymin_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Ymin_numeric.Value = new decimal(new int[] { 3, 0, 0, int.MinValue });
            Ymin_numeric.ValueChanged += Ymin_numeric_ValueChanged;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(34, 13);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(164, 32);
            label6.TabIndex = 0;
            label6.Text = "Y interval";
            // 
            // panel3
            // 
            panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            panel3.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(Points_numeric);
            panel3.Controls.Add(label9);
            panel3.Location = new System.Drawing.Point(661, 409);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(228, 102);
            panel3.TabIndex = 6;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(2, 62);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(70, 22);
            label8.TabIndex = 3;
            label8.Text = "Points";
            // 
            // Points_numeric
            // 
            Points_numeric.Anchor = System.Windows.Forms.AnchorStyles.Right;
            Points_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            Points_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Points_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Points_numeric.ForeColor = System.Drawing.Color.White;
            Points_numeric.Location = new System.Drawing.Point(78, 62);
            Points_numeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            Points_numeric.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            Points_numeric.Name = "Points_numeric";
            Points_numeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Points_numeric.Size = new System.Drawing.Size(120, 26);
            Points_numeric.TabIndex = 1;
            Points_numeric.Tag = "";
            Points_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Points_numeric.Value = new decimal(new int[] { 3, 0, 0, 0 });
            Points_numeric.ValueChanged += Points_numeric_ValueChanged;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(46, 13);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(134, 32);
            label9.TabIndex = 0;
            label9.Text = "Function";
            // 
            // panel4
            // 
            panel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            panel4.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(Step_numeric);
            panel4.Controls.Add(label11);
            panel4.Location = new System.Drawing.Point(661, 517);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(228, 102);
            panel4.TabIndex = 7;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(22, 62);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(50, 22);
            label10.TabIndex = 3;
            label10.Text = "Step";
            // 
            // Step_numeric
            // 
            Step_numeric.Anchor = System.Windows.Forms.AnchorStyles.Right;
            Step_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            Step_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Step_numeric.DecimalPlaces = 1;
            Step_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Step_numeric.ForeColor = System.Drawing.Color.White;
            Step_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            Step_numeric.Location = new System.Drawing.Point(78, 62);
            Step_numeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            Step_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            Step_numeric.Name = "Step_numeric";
            Step_numeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            Step_numeric.Size = new System.Drawing.Size(120, 26);
            Step_numeric.TabIndex = 1;
            Step_numeric.Tag = "";
            Step_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Step_numeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            Step_numeric.ValueChanged += Step_numeric_ValueChanged;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.White;
            label11.Location = new System.Drawing.Point(78, 10);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(74, 32);
            label11.TabIndex = 0;
            label11.Text = "Grid";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tabControl1.Location = new System.Drawing.Point(12, 15);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(643, 627);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tabPage1.Controls.Add(renderControl1);
            tabPage1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tabPage1.ForeColor = System.Drawing.Color.White;
            tabPage1.Location = new System.Drawing.Point(4, 31);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(635, 592);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "f(x) 1";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tabPage2.Controls.Add(renderControl2);
            tabPage2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tabPage2.ForeColor = System.Drawing.Color.White;
            tabPage2.Location = new System.Drawing.Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(635, 592);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "f(x) 2";
            // 
            // renderControl2
            // 
            renderControl2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl2.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            renderControl2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            renderControl2.ForeColor = System.Drawing.Color.White;
            renderControl2.Location = new System.Drawing.Point(3, 3);
            renderControl2.Name = "renderControl2";
            renderControl2.Size = new System.Drawing.Size(629, 586);
            renderControl2.TabIndex = 1;
            renderControl2.TextCodePage = 65001;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            ClientSize = new System.Drawing.Size(901, 654);
            Controls.Add(tabControl1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Lab 3";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Xmax_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)Xmin_numeric).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Ymax_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ymin_numeric).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Points_numeric).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Step_numeric).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Xmin_numeric;
        private System.Windows.Forms.NumericUpDown Xmax_numeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Ymax_numeric;
        private System.Windows.Forms.NumericUpDown Ymin_numeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown Points_numeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Step_numeric;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private RenderControl renderControl2;
        private System.Windows.Forms.CheckBox autoSizeY_checkBox;
    }
}

