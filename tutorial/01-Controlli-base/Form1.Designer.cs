namespace FirstSolution
{
    partial class Form1
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
            this.panelPart2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.isModal = new System.Windows.Forms.CheckBox();
            this.form2H = new System.Windows.Forms.TextBox();
            this.form2W = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbResizable = new System.Windows.Forms.RadioButton();
            this.rbFixed = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelPart1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.showHidePart2 = new System.Windows.Forms.Button();
            this.closeMeAfterClick = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelPart2.SuspendLayout();
            this.panelPart1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPart2
            // 
            this.panelPart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelPart2.Controls.Add(this.label6);
            this.panelPart2.Controls.Add(this.isModal);
            this.panelPart2.Controls.Add(this.form2H);
            this.panelPart2.Controls.Add(this.form2W);
            this.panelPart2.Controls.Add(this.label4);
            this.panelPart2.Controls.Add(this.label3);
            this.panelPart2.Controls.Add(this.rbResizable);
            this.panelPart2.Controls.Add(this.rbFixed);
            this.panelPart2.Controls.Add(this.label2);
            this.panelPart2.Controls.Add(this.button2);
            this.panelPart2.Location = new System.Drawing.Point(12, 173);
            this.panelPart2.Name = "panelPart2";
            this.panelPart2.Size = new System.Drawing.Size(426, 236);
            this.panelPart2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Part 2";
            // 
            // isModal
            // 
            this.isModal.AutoSize = true;
            this.isModal.Location = new System.Drawing.Point(13, 156);
            this.isModal.Name = "isModal";
            this.isModal.Size = new System.Drawing.Size(62, 17);
            this.isModal.TabIndex = 21;
            this.isModal.Text = "isModal";
            this.isModal.UseVisualStyleBackColor = true;
            // 
            // form2H
            // 
            this.form2H.Location = new System.Drawing.Point(232, 122);
            this.form2H.Name = "form2H";
            this.form2H.Size = new System.Drawing.Size(50, 20);
            this.form2H.TabIndex = 20;
            this.form2H.Text = "200";
            // 
            // form2W
            // 
            this.form2W.Location = new System.Drawing.Point(139, 122);
            this.form2W.Name = "form2W";
            this.form2W.Size = new System.Drawing.Size(50, 20);
            this.form2W.TabIndex = 19;
            this.form2W.Text = "300";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Width";
            // 
            // rbResizable
            // 
            this.rbResizable.AutoSize = true;
            this.rbResizable.Location = new System.Drawing.Point(14, 120);
            this.rbResizable.Name = "rbResizable";
            this.rbResizable.Size = new System.Drawing.Size(66, 17);
            this.rbResizable.TabIndex = 16;
            this.rbResizable.TabStop = true;
            this.rbResizable.Text = "resizable";
            this.rbResizable.UseVisualStyleBackColor = true;
            // 
            // rbFixed
            // 
            this.rbFixed.AutoSize = true;
            this.rbFixed.Location = new System.Drawing.Point(14, 97);
            this.rbFixed.Name = "rbFixed";
            this.rbFixed.Size = new System.Drawing.Size(68, 17);
            this.rbFixed.TabIndex = 15;
            this.rbFixed.TabStop = true;
            this.rbFixed.Text = "fixed size";
            this.rbFixed.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Choose the aspect of the form:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 22);
            this.button2.TabIndex = 13;
            this.button2.Text = "Create a new form2 window";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelPart1
            // 
            this.panelPart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelPart1.Controls.Add(this.label5);
            this.panelPart1.Controls.Add(this.showHidePart2);
            this.panelPart1.Controls.Add(this.closeMeAfterClick);
            this.panelPart1.Controls.Add(this.label1);
            this.panelPart1.Controls.Add(this.button1);
            this.panelPart1.Location = new System.Drawing.Point(12, 12);
            this.panelPart1.Name = "panelPart1";
            this.panelPart1.Size = new System.Drawing.Size(426, 143);
            this.panelPart1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Part 1";
            // 
            // showHidePart2
            // 
            this.showHidePart2.Location = new System.Drawing.Point(7, 113);
            this.showHidePart2.Name = "showHidePart2";
            this.showHidePart2.Size = new System.Drawing.Size(107, 23);
            this.showHidePart2.TabIndex = 18;
            this.showHidePart2.Text = "show / hide part 2";
            this.showHidePart2.UseVisualStyleBackColor = true;
            this.showHidePart2.Click += new System.EventHandler(this.showHidePart2_Click);
            // 
            // closeMeAfterClick
            // 
            this.closeMeAfterClick.AutoSize = true;
            this.closeMeAfterClick.Location = new System.Drawing.Point(97, 48);
            this.closeMeAfterClick.Name = "closeMeAfterClick";
            this.closeMeAfterClick.Size = new System.Drawing.Size(118, 17);
            this.closeMeAfterClick.TabIndex = 17;
            this.closeMeAfterClick.Text = "Close me after click";
            this.closeMeAfterClick.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "This is a label";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Click me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 421);
            this.Controls.Add(this.panelPart1);
            this.Controls.Add(this.panelPart2);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPart2.ResumeLayout(false);
            this.panelPart2.PerformLayout();
            this.panelPart1.ResumeLayout(false);
            this.panelPart1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelPart2;
        private System.Windows.Forms.CheckBox isModal;
        private System.Windows.Forms.TextBox form2H;
        private System.Windows.Forms.TextBox form2W;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbResizable;
        private System.Windows.Forms.RadioButton rbFixed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPart1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showHidePart2;
        private System.Windows.Forms.CheckBox closeMeAfterClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

