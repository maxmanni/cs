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
            this.buttonPulisci = new System.Windows.Forms.Button();
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
            this.saveButton = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeFile = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileNotepad = new System.Windows.Forms.Button();
            this.buttonDisegna = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelCottura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadButton)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPulisci
            // 
            this.buttonPulisci.Location = new System.Drawing.Point(12, 238);
            this.buttonPulisci.Name = "buttonPulisci";
            this.buttonPulisci.Size = new System.Drawing.Size(100, 25);
            this.buttonPulisci.TabIndex = 0;
            this.buttonPulisci.Text = "Pulisci form";
            this.buttonPulisci.UseVisualStyleBackColor = true;
            this.buttonPulisci.Click += new System.EventHandler(this.pulisciCampi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(108, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(183, 23);
            this.txtNome.TabIndex = 2;
            // 
            // checkVaCotta
            // 
            this.checkVaCotta.AutoSize = true;
            this.checkVaCotta.Location = new System.Drawing.Point(25, 62);
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
            this.panelCottura.Location = new System.Drawing.Point(108, 62);
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
            this.label4.Location = new System.Drawing.Point(17, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numero strati";
            // 
            // txtNumStrati
            // 
            this.txtNumStrati.Location = new System.Drawing.Point(108, 140);
            this.txtNumStrati.Name = "txtNumStrati";
            this.txtNumStrati.Size = new System.Drawing.Size(46, 23);
            this.txtNumStrati.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo copertura";
            // 
            // comboCopertura
            // 
            this.comboCopertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCopertura.FormattingEnabled = true;
            this.comboCopertura.Location = new System.Drawing.Point(108, 172);
            this.comboCopertura.Name = "comboCopertura";
            this.comboCopertura.Size = new System.Drawing.Size(183, 23);
            this.comboCopertura.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo farcitura";
            // 
            // comboFarcitura
            // 
            this.comboFarcitura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFarcitura.FormattingEnabled = true;
            this.comboFarcitura.Location = new System.Drawing.Point(108, 201);
            this.comboFarcitura.Name = "comboFarcitura";
            this.comboFarcitura.Size = new System.Drawing.Size(183, 23);
            this.comboFarcitura.TabIndex = 14;
            // 
            // panelDisegno
            // 
            this.panelDisegno.BackColor = System.Drawing.Color.White;
            this.panelDisegno.Location = new System.Drawing.Point(343, 12);
            this.panelDisegno.Name = "panelDisegno";
            this.panelDisegno.Size = new System.Drawing.Size(445, 429);
            this.panelDisegno.TabIndex = 15;
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Image = global::_05_ConfiguraTorta.Properties.Resources.save;
            this.saveButton.InitialImage = null;
            this.saveButton.Location = new System.Drawing.Point(192, 307);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 64);
            this.saveButton.TabIndex = 17;
            this.saveButton.TabStop = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Salva su file";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "percorso e nome file (*)";
            // 
            // txtNomeFile
            // 
            this.txtNomeFile.Location = new System.Drawing.Point(12, 327);
            this.txtNomeFile.Name = "txtNomeFile";
            this.txtNomeFile.Size = new System.Drawing.Size(161, 23);
            this.txtNomeFile.TabIndex = 20;
            this.txtNomeFile.Text = "torta1.txt";
            // 
            // loadButton
            // 
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadButton.Image = global::_05_ConfiguraTorta.Properties.Resources.load;
            this.loadButton.InitialImage = null;
            this.loadButton.Location = new System.Drawing.Point(262, 307);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(64, 64);
            this.loadButton.TabIndex = 21;
            this.loadButton.TabStop = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Carica da file";
            // 
            // openFileNotepad
            // 
            this.openFileNotepad.Location = new System.Drawing.Point(12, 356);
            this.openFileNotepad.Name = "openFileNotepad";
            this.openFileNotepad.Size = new System.Drawing.Size(161, 25);
            this.openFileNotepad.TabIndex = 23;
            this.openFileNotepad.Text = "Open file in notepad";
            this.openFileNotepad.UseVisualStyleBackColor = true;
            this.openFileNotepad.Click += new System.EventHandler(this.openFileNotepad_Click);
            // 
            // buttonDisegna
            // 
            this.buttonDisegna.Location = new System.Drawing.Point(156, 238);
            this.buttonDisegna.Name = "buttonDisegna";
            this.buttonDisegna.Size = new System.Drawing.Size(135, 25);
            this.buttonDisegna.TabIndex = 24;
            this.buttonDisegna.Text = "Disegna torta";
            this.buttonDisegna.UseVisualStyleBackColor = true;
            this.buttonDisegna.Click += new System.EventHandler(this.buttonDisegna_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(7, 391);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(330, 50);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "(*) specificando solo un nome, senza percorso, il file viene creato nella stessa " +
    "cartella dove si genera l\'eseguibile (bin/Debug)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDisegna);
            this.Controls.Add(this.openFileNotepad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.txtNomeFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saveButton);
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
            this.Controls.Add(this.buttonPulisci);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Configuratore torte";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelCottura.ResumeLayout(false);
            this.panelCottura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.saveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		
		private Button buttonPulisci;
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
        private PictureBox saveButton;
        private Label label7;
        private Label label8;
        private TextBox txtNomeFile;
        private PictureBox loadButton;
        private Label label9;
        private Button openFileNotepad;
        private Button buttonDisegna;
        private TextBox textBox1;
    }
}