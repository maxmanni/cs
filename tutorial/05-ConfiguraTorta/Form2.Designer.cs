﻿namespace _05_ConfiguraTorta
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nuova = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.checkVaCotta = new System.Windows.Forms.CheckBox();
            this.panelCottura = new System.Windows.Forms.Panel();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumStrati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCopertura = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboFarcitura = new System.Windows.Forms.ComboBox();
            this.panelDisegno = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeFile = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panelCottura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nuova
            // 
            this.nuova.Location = new System.Drawing.Point(39, 28);
            this.nuova.Name = "nuova";
            this.nuova.Size = new System.Drawing.Size(76, 27);
            this.nuova.TabIndex = 0;
            this.nuova.Text = "Nuova";
            this.nuova.UseVisualStyleBackColor = true;
            this.nuova.Click += new System.EventHandler(this.nuova_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(109, 84);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 2;
            // 
            // checkVaCotta
            // 
            this.checkVaCotta.AutoSize = true;
            this.checkVaCotta.Location = new System.Drawing.Point(26, 126);
            this.checkVaCotta.Name = "checkVaCotta";
            this.checkVaCotta.Size = new System.Drawing.Size(68, 19);
            this.checkVaCotta.TabIndex = 3;
            this.checkVaCotta.Text = "va cotta";
            this.checkVaCotta.UseVisualStyleBackColor = true;
            this.checkVaCotta.CheckedChanged += new System.EventHandler(this.checkVaCotta_CheckedChanged);
            // 
            // panelCottura
            // 
            this.panelCottura.Controls.Add(this.txtTempo);
            this.panelCottura.Controls.Add(this.label3);
            this.panelCottura.Controls.Add(this.txtTemperatura);
            this.panelCottura.Controls.Add(this.label2);
            this.panelCottura.Location = new System.Drawing.Point(109, 126);
            this.panelCottura.Name = "panelCottura";
            this.panelCottura.Size = new System.Drawing.Size(194, 68);
            this.panelCottura.TabIndex = 8;
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(83, 38);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(100, 23);
            this.txtTempo.TabIndex = 11;
            this.txtTempo.Text = "60";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "tempo (min.)";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(83, 4);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 23);
            this.txtTemperatura.TabIndex = 9;
            this.txtTemperatura.Text = "180";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "temp. (\"C)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numero strati";
            // 
            // txtNumStrati
            // 
            this.txtNumStrati.Location = new System.Drawing.Point(112, 213);
            this.txtNumStrati.Name = "txtNumStrati";
            this.txtNumStrati.Size = new System.Drawing.Size(101, 23);
            this.txtNumStrati.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "tipo copertura";
            // 
            // comboCopertura
            // 
            this.comboCopertura.FormattingEnabled = true;
            this.comboCopertura.Location = new System.Drawing.Point(112, 253);
            this.comboCopertura.Name = "comboCopertura";
            this.comboCopertura.Size = new System.Drawing.Size(121, 23);
            this.comboCopertura.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "tipo farcitura";
            // 
            // comboFarcitura
            // 
            this.comboFarcitura.FormattingEnabled = true;
            this.comboFarcitura.Location = new System.Drawing.Point(118, 300);
            this.comboFarcitura.Name = "comboFarcitura";
            this.comboFarcitura.Size = new System.Drawing.Size(115, 23);
            this.comboFarcitura.TabIndex = 14;
            // 
            // panelDisegno
            // 
            this.panelDisegno.BackColor = System.Drawing.Color.White;
            this.panelDisegno.Location = new System.Drawing.Point(368, 24);
            this.panelDisegno.Name = "panelDisegno";
            this.panelDisegno.Size = new System.Drawing.Size(420, 417);
            this.panelDisegno.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(208, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Salva su file";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "nome file";
            // 
            // txtNomeFile
            // 
            this.txtNomeFile.Location = new System.Drawing.Point(88, 412);
            this.txtNomeFile.Name = "txtNomeFile";
            this.txtNomeFile.Size = new System.Drawing.Size(100, 23);
            this.txtNomeFile.TabIndex = 20;
            this.txtNomeFile.Text = "torta1.txt";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(278, 353);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Carica da file";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtNomeFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelDisegno);
            this.Controls.Add(this.comboFarcitura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboCopertura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumStrati);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelCottura);
            this.Controls.Add(this.checkVaCotta);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuova);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panelCottura.ResumeLayout(false);
            this.panelCottura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		
		private Button nuova;
        private Label label1;
        private TextBox txtNome;
        private CheckBox checkVaCotta;
        private Panel panelCottura;
        private TextBox txtTempo;
        private Label label3;
        private TextBox txtTemperatura;
        private Label label2;
        private Label label4;
        private TextBox txtNumStrati;
        private Label label5;
        private ComboBox comboCopertura;
        private Label label6;
        private ComboBox comboFarcitura;
        private Panel panelDisegno;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private TextBox txtNomeFile;
        private PictureBox pictureBox2;
        private Label label9;
    }
}