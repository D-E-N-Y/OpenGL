
namespace OpenGL_Lab_2
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
            horValue = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            verValue = new System.Windows.Forms.NumericUpDown();
            fillMode = new System.Windows.Forms.RadioButton();
            lineMode = new System.Windows.Forms.RadioButton();
            pointsMode = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            flatModel = new System.Windows.Forms.RadioButton();
            smoothModel = new System.Windows.Forms.RadioButton();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)horValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)verValue).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            renderControl1.ForeColor = System.Drawing.Color.Black;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(600, 557);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 65001;
            // 
            // horValue
            // 
            horValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            horValue.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            horValue.Font = new System.Drawing.Font("Consolas", 14.25F);
            horValue.ForeColor = System.Drawing.Color.White;
            horValue.Location = new System.Drawing.Point(768, 92);
            horValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            horValue.Name = "horValue";
            horValue.Size = new System.Drawing.Size(86, 30);
            horValue.TabIndex = 1;
            horValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            horValue.ValueChanged += horValue_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(632, 94);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(130, 22);
            label1.TabIndex = 2;
            label1.Text = "horizontal :";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(632, 139);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(130, 22);
            label2.TabIndex = 4;
            label2.Text = "vertical   :";
            // 
            // verValue
            // 
            verValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            verValue.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            verValue.Font = new System.Drawing.Font("Consolas", 14.25F);
            verValue.ForeColor = System.Drawing.Color.White;
            verValue.Location = new System.Drawing.Point(768, 137);
            verValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            verValue.Name = "verValue";
            verValue.Size = new System.Drawing.Size(86, 30);
            verValue.TabIndex = 3;
            verValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            verValue.ValueChanged += verValue_ValueChanged;
            // 
            // fillMode
            // 
            fillMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            fillMode.AutoSize = true;
            fillMode.Checked = true;
            fillMode.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            fillMode.ForeColor = System.Drawing.Color.White;
            fillMode.Location = new System.Drawing.Point(11, 52);
            fillMode.Name = "fillMode";
            fillMode.Size = new System.Drawing.Size(68, 26);
            fillMode.TabIndex = 5;
            fillMode.TabStop = true;
            fillMode.Text = "FILL";
            fillMode.UseVisualStyleBackColor = true;
            fillMode.CheckedChanged += fillMode_CheckedChanged;
            // 
            // lineMode
            // 
            lineMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            lineMode.AutoSize = true;
            lineMode.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lineMode.ForeColor = System.Drawing.Color.White;
            lineMode.Location = new System.Drawing.Point(11, 84);
            lineMode.Name = "lineMode";
            lineMode.Size = new System.Drawing.Size(68, 26);
            lineMode.TabIndex = 6;
            lineMode.Text = "LINE";
            lineMode.UseVisualStyleBackColor = true;
            lineMode.CheckedChanged += lineMode_CheckedChanged;
            // 
            // pointsMode
            // 
            pointsMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pointsMode.AutoSize = true;
            pointsMode.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            pointsMode.ForeColor = System.Drawing.Color.White;
            pointsMode.Location = new System.Drawing.Point(11, 116);
            pointsMode.Name = "pointsMode";
            pointsMode.Size = new System.Drawing.Size(88, 26);
            pointsMode.TabIndex = 7;
            pointsMode.Text = "POINTS";
            pointsMode.UseVisualStyleBackColor = true;
            pointsMode.CheckedChanged += pointsMode_CheckedChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(22, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(194, 28);
            label3.TabIndex = 8;
            label3.Text = "MODE OF FIGURE";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(634, 52);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(220, 28);
            label4.TabIndex = 9;
            label4.Text = "COUNT OF FIGURES";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(22, 12);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(155, 28);
            label5.TabIndex = 12;
            label5.Text = "SHADE MODEL";
            // 
            // flatModel
            // 
            flatModel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            flatModel.AutoSize = true;
            flatModel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            flatModel.ForeColor = System.Drawing.Color.White;
            flatModel.Location = new System.Drawing.Point(11, 84);
            flatModel.Name = "flatModel";
            flatModel.Size = new System.Drawing.Size(68, 26);
            flatModel.TabIndex = 11;
            flatModel.Text = "FLAT";
            flatModel.UseVisualStyleBackColor = true;
            flatModel.CheckedChanged += flatModel_CheckedChanged;
            // 
            // smoothModel
            // 
            smoothModel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            smoothModel.AutoSize = true;
            smoothModel.Checked = true;
            smoothModel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            smoothModel.ForeColor = System.Drawing.Color.White;
            smoothModel.Location = new System.Drawing.Point(11, 52);
            smoothModel.Name = "smoothModel";
            smoothModel.Size = new System.Drawing.Size(88, 26);
            smoothModel.TabIndex = 10;
            smoothModel.TabStop = true;
            smoothModel.Text = "SMOOTH";
            smoothModel.UseVisualStyleBackColor = true;
            smoothModel.CheckedChanged += smoothModel_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(fillMode);
            panel1.Controls.Add(lineMode);
            panel1.Controls.Add(pointsMode);
            panel1.Location = new System.Drawing.Point(632, 190);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(222, 151);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(smoothModel);
            panel2.Controls.Add(flatModel);
            panel2.Location = new System.Drawing.Point(632, 370);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(222, 151);
            panel2.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(17, 17, 17);
            ClientSize = new System.Drawing.Size(873, 581);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(verValue);
            Controls.Add(label1);
            Controls.Add(horValue);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Lab 2";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)horValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)verValue).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.NumericUpDown horValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown verValue;
        private System.Windows.Forms.RadioButton fillMode;
        private System.Windows.Forms.RadioButton lineMode;
        private System.Windows.Forms.RadioButton pointsMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton flatModel;
        private System.Windows.Forms.RadioButton smoothModel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

