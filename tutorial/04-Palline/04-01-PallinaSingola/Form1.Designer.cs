namespace Project2_Graphics
{
    partial class Form1
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
            this.pianoCartesiano = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stop = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.coordPunto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coordMouse = new System.Windows.Forms.Label();
            this.dimPiano = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.palla = new System.Windows.Forms.PictureBox();
            this.pianoCartesiano.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palla)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pianoCartesiano
            // 
            this.pianoCartesiano.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pianoCartesiano.BackColor = System.Drawing.Color.White;
            this.pianoCartesiano.Controls.Add(this.palla);
            this.pianoCartesiano.ForeColor = System.Drawing.Color.Red;
            this.pianoCartesiano.Location = new System.Drawing.Point(115, 0);
            this.pianoCartesiano.Name = "pianoCartesiano";
            this.pianoCartesiano.Size = new System.Drawing.Size(708, 460);
            this.pianoCartesiano.TabIndex = 2;
            this.pianoCartesiano.Paint += new System.Windows.Forms.PaintEventHandler(this.pianoOnPaint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.stop);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 504);
            this.panel1.TabIndex = 3;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(24, 146);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(51, 27);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(24, 98);
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
            this.panel2.Location = new System.Drawing.Point(118, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 44);
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
            this.dimPiano.Location = new System.Drawing.Point(596, 24);
            this.dimPiano.Name = "dimPiano";
            this.dimPiano.Size = new System.Drawing.Size(25, 15);
            this.dimPiano.TabIndex = 4;
            this.dimPiano.Text = "0, 0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dimensione piano";
            // 
            // palla
            // 
            this.palla.BackColor = System.Drawing.Color.Red;
            this.palla.Location = new System.Drawing.Point(0, 0);
            this.palla.Name = "palla";
            this.palla.Size = new System.Drawing.Size(30, 30);
            this.palla.TabIndex = 0;
            this.palla.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pianoCartesiano);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pianoCartesiano.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.palla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel pianoCartesiano;
        private Panel panel1;
        private Panel panel2;
        private Label dimPiano;
        private Label label1;
        private Label label2;
        private Label coordMouse;
        private Label coordPunto;
        private Label label6;
        private Button startButton;
        private Button stop;
        private PictureBox palla;
    }
}