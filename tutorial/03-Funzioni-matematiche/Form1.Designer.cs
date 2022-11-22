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
            this.drawExp = new System.Windows.Forms.CheckBox();
            this.drawQuad = new System.Windows.Forms.CheckBox();
            this.apply = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.drawCos = new System.Windows.Forms.CheckBox();
            this.drawSin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drawAxes = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.coordPunto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtZoom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coordMouse = new System.Windows.Forms.Label();
            this.dimPiano = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pianoCartesiano
            // 
            this.pianoCartesiano.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pianoCartesiano.BackColor = System.Drawing.Color.White;
            this.pianoCartesiano.Location = new System.Drawing.Point(115, 0);
            this.pianoCartesiano.Name = "pianoCartesiano";
            this.pianoCartesiano.Size = new System.Drawing.Size(708, 460);
            this.pianoCartesiano.TabIndex = 2;
            this.pianoCartesiano.Paint += new System.Windows.Forms.PaintEventHandler(this.pianoOnPaint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.drawExp);
            this.panel1.Controls.Add(this.drawQuad);
            this.panel1.Controls.Add(this.apply);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtStep);
            this.panel1.Controls.Add(this.drawCos);
            this.panel1.Controls.Add(this.drawSin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.drawAxes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 504);
            this.panel1.TabIndex = 3;
            // 
            // drawExp
            // 
            this.drawExp.AutoSize = true;
            this.drawExp.Location = new System.Drawing.Point(12, 158);
            this.drawExp.Name = "drawExp";
            this.drawExp.Size = new System.Drawing.Size(69, 19);
            this.drawExp.TabIndex = 8;
            this.drawExp.Text = "y = e ^x";
            this.drawExp.UseVisualStyleBackColor = true;
            this.drawExp.CheckedChanged += new System.EventHandler(this.drawExp_CheckedChanged);
            // 
            // drawQuad
            // 
            this.drawQuad.AutoSize = true;
            this.drawQuad.Location = new System.Drawing.Point(12, 80);
            this.drawQuad.Name = "drawQuad";
            this.drawQuad.Size = new System.Drawing.Size(66, 19);
            this.drawQuad.TabIndex = 7;
            this.drawQuad.Text = "y = x^2";
            this.drawQuad.UseVisualStyleBackColor = true;
            this.drawQuad.CheckedChanged += new System.EventHandler(this.drawQuad_CheckedChanged);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(9, 265);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(59, 22);
            this.apply.TabIndex = 6;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Draw Step";
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(8, 236);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(60, 23);
            this.txtStep.TabIndex = 4;
            this.txtStep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // drawCos
            // 
            this.drawCos.AutoSize = true;
            this.drawCos.Location = new System.Drawing.Point(12, 133);
            this.drawCos.Name = "drawCos";
            this.drawCos.Size = new System.Drawing.Size(81, 19);
            this.drawCos.TabIndex = 3;
            this.drawCos.Text = "y = cos (x)";
            this.drawCos.UseVisualStyleBackColor = true;
            this.drawCos.CheckedChanged += new System.EventHandler(this.drawCos_CheckedChanged);
            // 
            // drawSin
            // 
            this.drawSin.AutoSize = true;
            this.drawSin.Location = new System.Drawing.Point(12, 108);
            this.drawSin.Name = "drawSin";
            this.drawSin.Size = new System.Drawing.Size(78, 19);
            this.drawSin.TabIndex = 2;
            this.drawSin.Text = "y = sin (x)";
            this.drawSin.UseVisualStyleBackColor = true;
            this.drawSin.CheckedChanged += new System.EventHandler(this.drawSin_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Functions";
            // 
            // drawAxes
            // 
            this.drawAxes.AutoSize = true;
            this.drawAxes.Checked = true;
            this.drawAxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawAxes.Location = new System.Drawing.Point(12, 22);
            this.drawAxes.Name = "drawAxes";
            this.drawAxes.Size = new System.Drawing.Size(49, 19);
            this.drawAxes.TabIndex = 0;
            this.drawAxes.Text = "axes";
            this.drawAxes.UseVisualStyleBackColor = true;
            this.drawAxes.CheckedChanged += new System.EventHandler(this.drawAxes_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.coordPunto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtZoom);
            this.panel2.Controls.Add(this.label5);
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
            // txtZoom
            // 
            this.txtZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtZoom.AutoSize = true;
            this.txtZoom.Location = new System.Drawing.Point(277, 24);
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Size = new System.Drawing.Size(35, 15);
            this.txtZoom.TabIndex = 8;
            this.txtZoom.Text = "100%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zoom";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private CheckBox drawCos;
        private CheckBox drawSin;
        private Label label3;
        private CheckBox drawAxes;
        private Label label4;
        private TextBox txtStep;
        private Button apply;
        private Label txtZoom;
        private Label label5;
        private Label coordPunto;
        private Label label6;
        private CheckBox drawQuad;
        private CheckBox drawExp;
    }
}