namespace Project2_Graphics
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pannello = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCount = new System.Windows.Forms.Label();
            this.textN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textWaitMax = new System.Windows.Forms.TextBox();
            this.textWaitMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textStep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.coordPunto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coordMouse = new System.Windows.Forms.Label();
            this.dimPiano = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pannello
            // 
            this.pannello.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pannello.BackColor = System.Drawing.Color.White;
            this.pannello.ForeColor = System.Drawing.Color.Red;
            this.pannello.Location = new System.Drawing.Point(148, 0);
            this.pannello.Name = "pannello";
            this.pannello.Size = new System.Drawing.Size(671, 425);
            this.pannello.TabIndex = 2;
            this.pannello.Paint += new System.Windows.Forms.PaintEventHandler(this.pianoOnPaint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.labelCount);
            this.panel1.Controls.Add(this.textN);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textWaitMax);
            this.panel1.Controls.Add(this.textWaitMin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textStep);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 511);
            this.panel1.TabIndex = 3;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(23, 32);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(52, 15);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "Palle = 0";
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(45, 6);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(70, 23);
            this.textN.TabIndex = 10;
            this.textN.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "N";
            // 
            // textWaitMax
            // 
            this.textWaitMax.Location = new System.Drawing.Point(71, 166);
            this.textWaitMax.Name = "textWaitMax";
            this.textWaitMax.Size = new System.Drawing.Size(44, 23);
            this.textWaitMax.TabIndex = 8;
            this.textWaitMax.Text = "100";
            // 
            // textWaitMin
            // 
            this.textWaitMin.Location = new System.Drawing.Point(71, 133);
            this.textWaitMin.Name = "textWaitMin";
            this.textWaitMin.Size = new System.Drawing.Size(44, 23);
            this.textWaitMin.TabIndex = 7;
            this.textWaitMin.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "waitMax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "waitMin";
            // 
            // textStep
            // 
            this.textStep.Location = new System.Drawing.Point(68, 99);
            this.textStep.Name = "textStep";
            this.textStep.Size = new System.Drawing.Size(47, 23);
            this.textStep.TabIndex = 4;
            this.textStep.Text = "0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "step";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(15, 199);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(51, 27);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stop_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 60);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(51, 27);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.coordPunto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.coordMouse);
            this.panel2.Controls.Add(this.dimPiano);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(148, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 44);
            this.panel2.TabIndex = 4;
            // 
            // coordPunto
            // 
            this.coordPunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.coordPunto.AutoSize = true;
            this.coordPunto.Location = new System.Drawing.Point(111, 24);
            this.coordPunto.Name = "coordPunto";
            this.coordPunto.Size = new System.Drawing.Size(25, 15);
            this.coordPunto.TabIndex = 10;
            this.coordPunto.Text = "0, 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Coordinate punto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Coordinate mouse";
            // 
            // coordMouse
            // 
            this.coordMouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.coordMouse.AutoSize = true;
            this.coordMouse.Location = new System.Drawing.Point(111, 3);
            this.coordMouse.Name = "coordMouse";
            this.coordMouse.Size = new System.Drawing.Size(25, 15);
            this.coordMouse.TabIndex = 5;
            this.coordMouse.Text = "0, 0";
            // 
            // dimPiano
            // 
            this.dimPiano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dimPiano.AutoSize = true;
            this.dimPiano.Location = new System.Drawing.Point(562, 24);
            this.dimPiano.Name = "dimPiano";
            this.dimPiano.Size = new System.Drawing.Size(25, 15);
            this.dimPiano.TabIndex = 4;
            this.dimPiano.Text = "0, 0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dimensione piano";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pannello);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel pannello;
        private Panel panel1;
        private Panel panel2;
        private Label dimPiano;
        private Label label1;
        private Label label2;
        private Label coordMouse;
        private Label coordPunto;
        private Label label6;
        private Button startButton;
        private Button stopButton;
        private TextBox textWaitMax;
        private TextBox textWaitMin;
        private Label label5;
        private Label label4;
        private TextBox textStep;
        private Label label3;
        private TextBox textN;
        private Label label7;
        private Label labelCount;
    }
}