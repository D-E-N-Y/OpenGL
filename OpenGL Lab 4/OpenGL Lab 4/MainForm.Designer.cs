
namespace OpenGL_Lab_4
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
            label1 = new System.Windows.Forms.Label();
            curve_panel = new System.Windows.Forms.Panel();
            curve_comboBox = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            circle_panel = new System.Windows.Forms.Panel();
            radius_numeric = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            point2_y_numeric = new System.Windows.Forms.NumericUpDown();
            point1_y_numeric = new System.Windows.Forms.NumericUpDown();
            point2_x_numeric = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            point1_x_numeric = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            line_panel = new System.Windows.Forms.Panel();
            drawLine_button = new System.Windows.Forms.Button();
            hyperbole_panel = new System.Windows.Forms.Panel();
            label10 = new System.Windows.Forms.Label();
            hyp_b_numeric = new System.Windows.Forms.NumericUpDown();
            hyp_a_numeric = new System.Windows.Forms.NumericUpDown();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            curve_panel.SuspendLayout();
            circle_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)radius_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)point2_y_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)point1_y_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)point2_x_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)point1_x_numeric).BeginInit();
            line_panel.SuspendLayout();
            hyperbole_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hyp_b_numeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hyp_a_numeric).BeginInit();
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
            renderControl1.Size = new System.Drawing.Size(603, 573);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 65001;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(25, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 32);
            label1.TabIndex = 1;
            label1.Text = "Curve graph";
            // 
            // curve_panel
            // 
            curve_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            curve_panel.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            curve_panel.Controls.Add(curve_comboBox);
            curve_panel.Controls.Add(label2);
            curve_panel.Controls.Add(label1);
            curve_panel.Location = new System.Drawing.Point(621, 12);
            curve_panel.Name = "curve_panel";
            curve_panel.Size = new System.Drawing.Size(229, 108);
            curve_panel.TabIndex = 2;
            // 
            // curve_comboBox
            // 
            curve_comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            curve_comboBox.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            curve_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            curve_comboBox.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            curve_comboBox.ForeColor = System.Drawing.Color.White;
            curve_comboBox.FormattingEnabled = true;
            curve_comboBox.Items.AddRange(new object[] { "Circle", "Hyperbole" });
            curve_comboBox.Location = new System.Drawing.Point(83, 65);
            curve_comboBox.Name = "curve_comboBox";
            curve_comboBox.Size = new System.Drawing.Size(137, 30);
            curve_comboBox.TabIndex = 0;
            curve_comboBox.Text = "Circle";
            curve_comboBox.SelectedIndexChanged += curve_comboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(7, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 22);
            label2.TabIndex = 2;
            label2.Text = "Curve";
            // 
            // circle_panel
            // 
            circle_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            circle_panel.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            circle_panel.Controls.Add(radius_numeric);
            circle_panel.Controls.Add(label3);
            circle_panel.Controls.Add(label4);
            circle_panel.Location = new System.Drawing.Point(621, 126);
            circle_panel.Name = "circle_panel";
            circle_panel.Size = new System.Drawing.Size(229, 112);
            circle_panel.TabIndex = 3;
            // 
            // radius_numeric
            // 
            radius_numeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            radius_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            radius_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            radius_numeric.DecimalPlaces = 1;
            radius_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            radius_numeric.ForeColor = System.Drawing.Color.White;
            radius_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            radius_numeric.Location = new System.Drawing.Point(83, 62);
            radius_numeric.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            radius_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            radius_numeric.Name = "radius_numeric";
            radius_numeric.Size = new System.Drawing.Size(137, 26);
            radius_numeric.TabIndex = 4;
            radius_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            radius_numeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            radius_numeric.ValueChanged += radius_numeric_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(7, 64);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 22);
            label3.TabIndex = 3;
            label3.Text = "Radius";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(69, 11);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(104, 32);
            label4.TabIndex = 1;
            label4.Text = "Circle";
            // 
            // point2_y_numeric
            // 
            point2_y_numeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            point2_y_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            point2_y_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            point2_y_numeric.DecimalPlaces = 1;
            point2_y_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            point2_y_numeric.ForeColor = System.Drawing.Color.White;
            point2_y_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            point2_y_numeric.Location = new System.Drawing.Point(156, 101);
            point2_y_numeric.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            point2_y_numeric.Minimum = new decimal(new int[] { 3, 0, 0, int.MinValue });
            point2_y_numeric.Name = "point2_y_numeric";
            point2_y_numeric.Size = new System.Drawing.Size(64, 26);
            point2_y_numeric.TabIndex = 11;
            point2_y_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // point1_y_numeric
            // 
            point1_y_numeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            point1_y_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            point1_y_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            point1_y_numeric.DecimalPlaces = 1;
            point1_y_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            point1_y_numeric.ForeColor = System.Drawing.Color.White;
            point1_y_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            point1_y_numeric.Location = new System.Drawing.Point(156, 56);
            point1_y_numeric.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            point1_y_numeric.Minimum = new decimal(new int[] { 3, 0, 0, int.MinValue });
            point1_y_numeric.Name = "point1_y_numeric";
            point1_y_numeric.Size = new System.Drawing.Size(64, 26);
            point1_y_numeric.TabIndex = 10;
            point1_y_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // point2_x_numeric
            // 
            point2_x_numeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            point2_x_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            point2_x_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            point2_x_numeric.DecimalPlaces = 1;
            point2_x_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            point2_x_numeric.ForeColor = System.Drawing.Color.White;
            point2_x_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            point2_x_numeric.Location = new System.Drawing.Point(83, 101);
            point2_x_numeric.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            point2_x_numeric.Minimum = new decimal(new int[] { 3, 0, 0, int.MinValue });
            point2_x_numeric.Name = "point2_x_numeric";
            point2_x_numeric.Size = new System.Drawing.Size(64, 26);
            point2_x_numeric.TabIndex = 9;
            point2_x_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(3, 103);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(80, 22);
            label7.TabIndex = 8;
            label7.Text = "Point 2";
            // 
            // point1_x_numeric
            // 
            point1_x_numeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            point1_x_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            point1_x_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            point1_x_numeric.DecimalPlaces = 1;
            point1_x_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            point1_x_numeric.ForeColor = System.Drawing.Color.White;
            point1_x_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            point1_x_numeric.Location = new System.Drawing.Point(83, 56);
            point1_x_numeric.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            point1_x_numeric.Minimum = new decimal(new int[] { 3, 0, 0, int.MinValue });
            point1_x_numeric.Name = "point1_x_numeric";
            point1_x_numeric.Size = new System.Drawing.Size(64, 26);
            point1_x_numeric.TabIndex = 7;
            point1_x_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(3, 58);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(80, 22);
            label6.TabIndex = 6;
            label6.Text = "Point 1\r\n";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(83, 10);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(74, 32);
            label5.TabIndex = 5;
            label5.Text = "Line";
            // 
            // line_panel
            // 
            line_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            line_panel.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            line_panel.Controls.Add(drawLine_button);
            line_panel.Controls.Add(point2_y_numeric);
            line_panel.Controls.Add(label5);
            line_panel.Controls.Add(point1_y_numeric);
            line_panel.Controls.Add(label6);
            line_panel.Controls.Add(point2_x_numeric);
            line_panel.Controls.Add(point1_x_numeric);
            line_panel.Controls.Add(label7);
            line_panel.Location = new System.Drawing.Point(621, 244);
            line_panel.Name = "line_panel";
            line_panel.Size = new System.Drawing.Size(229, 198);
            line_panel.TabIndex = 3;
            // 
            // drawLine_button
            // 
            drawLine_button.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            drawLine_button.FlatAppearance.BorderSize = 0;
            drawLine_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            drawLine_button.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            drawLine_button.ForeColor = System.Drawing.Color.White;
            drawLine_button.Location = new System.Drawing.Point(83, 149);
            drawLine_button.Name = "drawLine_button";
            drawLine_button.Size = new System.Drawing.Size(74, 36);
            drawLine_button.TabIndex = 12;
            drawLine_button.Text = "draw";
            drawLine_button.UseVisualStyleBackColor = false;
            drawLine_button.Click += drawLine_button_Click;
            // 
            // hyperbole_panel
            // 
            hyperbole_panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            hyperbole_panel.BackColor = System.Drawing.Color.FromArgb(22, 22, 22);
            hyperbole_panel.Controls.Add(label10);
            hyperbole_panel.Controls.Add(hyp_b_numeric);
            hyperbole_panel.Controls.Add(hyp_a_numeric);
            hyperbole_panel.Controls.Add(label8);
            hyperbole_panel.Controls.Add(label9);
            hyperbole_panel.Enabled = false;
            hyperbole_panel.Location = new System.Drawing.Point(621, 448);
            hyperbole_panel.Name = "hyperbole_panel";
            hyperbole_panel.Size = new System.Drawing.Size(229, 137);
            hyperbole_panel.TabIndex = 5;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.White;
            label10.Location = new System.Drawing.Point(7, 96);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(70, 22);
            label10.TabIndex = 6;
            label10.Text = "Parm b";
            // 
            // hyp_b_numeric
            // 
            hyp_b_numeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            hyp_b_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            hyp_b_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            hyp_b_numeric.DecimalPlaces = 1;
            hyp_b_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            hyp_b_numeric.ForeColor = System.Drawing.Color.White;
            hyp_b_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            hyp_b_numeric.Location = new System.Drawing.Point(83, 94);
            hyp_b_numeric.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            hyp_b_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            hyp_b_numeric.Name = "hyp_b_numeric";
            hyp_b_numeric.Size = new System.Drawing.Size(137, 26);
            hyp_b_numeric.TabIndex = 5;
            hyp_b_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            hyp_b_numeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            hyp_b_numeric.ValueChanged += hyp_b_numeric_ValueChanged;
            // 
            // hyp_a_numeric
            // 
            hyp_a_numeric.Anchor = System.Windows.Forms.AnchorStyles.None;
            hyp_a_numeric.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            hyp_a_numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            hyp_a_numeric.DecimalPlaces = 1;
            hyp_a_numeric.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            hyp_a_numeric.ForeColor = System.Drawing.Color.White;
            hyp_a_numeric.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            hyp_a_numeric.Location = new System.Drawing.Point(83, 58);
            hyp_a_numeric.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            hyp_a_numeric.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            hyp_a_numeric.Name = "hyp_a_numeric";
            hyp_a_numeric.Size = new System.Drawing.Size(137, 26);
            hyp_a_numeric.TabIndex = 4;
            hyp_a_numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            hyp_a_numeric.Value = new decimal(new int[] { 2, 0, 0, 0 });
            hyp_a_numeric.ValueChanged += hyp_a_numeric_ValueChanged;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(7, 58);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(70, 22);
            label8.TabIndex = 3;
            label8.Text = "Parm a";
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.White;
            label9.Location = new System.Drawing.Point(43, 12);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(149, 32);
            label9.TabIndex = 1;
            label9.Text = "Hyperbole";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            ClientSize = new System.Drawing.Size(862, 597);
            Controls.Add(hyperbole_panel);
            Controls.Add(line_panel);
            Controls.Add(circle_panel);
            Controls.Add(curve_panel);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Lab 4";
            curve_panel.ResumeLayout(false);
            curve_panel.PerformLayout();
            circle_panel.ResumeLayout(false);
            circle_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)radius_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)point2_y_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)point1_y_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)point2_x_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)point1_x_numeric).EndInit();
            line_panel.ResumeLayout(false);
            line_panel.PerformLayout();
            hyperbole_panel.ResumeLayout(false);
            hyperbole_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hyp_b_numeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)hyp_a_numeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel curve_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox curve_comboBox;
        private System.Windows.Forms.Panel circle_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown radius_numeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown point2_y_numeric;
        private System.Windows.Forms.NumericUpDown point1_y_numeric;
        private System.Windows.Forms.NumericUpDown point2_x_numeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown point1_x_numeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel line_panel;
        private System.Windows.Forms.Button drawLine_button;
        private System.Windows.Forms.Panel hyperbole_panel;
        private System.Windows.Forms.NumericUpDown hyp_a_numeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown hyp_b_numeric;
    }
}

