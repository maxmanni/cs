using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstSolution
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button1_Click");
            label1.Text = "Hello world!!!";
            label1.BackColor = Color.FromArgb(255, 255, 0);
            Console.WriteLine("label1.Text = {0}", label1.Text);
            if (closeMeAfterClick.Checked)
            {
                Console.WriteLine("CLOSE");
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
            rbFixed.Checked = true;
            rbResizable.Checked = false;
            panelPart2.Visible = false;
            this.FormClosing += AllaChiusura;
        }

        private void AllaChiusura(Object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Form1_FormClosing");
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show("Are you sure you want to exit?",
                                        "Exit?",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            int w = Convert.ToInt32(form2W.Text);
            int h = Convert.ToInt32(form2H.Text);
            form2.Size = new Size(w, h);
            if (rbResizable.Checked)
            {
                form2.FormBorderStyle = FormBorderStyle.Sizable;
                form2.Text = "Resizable";
            } else if (rbFixed.Checked)
            {
                form2.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                form2.Text = "Fixed";
            }
            if (isModal.Checked)
            {
                form2.ShowDialog(this);
            } else
            {
                form2.Show();
            }
            
        }

        private void rbFixed_CheckedChanged(object sender, EventArgs e)
        {
            rbResizable.Checked = !rbFixed.Checked;

        }

        private void rbResizable_CheckedChanged(object sender, EventArgs e)
        {
            rbFixed.Checked = !rbResizable.Checked;
        }

        private void showHidePart2_Click(object sender, EventArgs e)
        {
            panelPart2.Visible = !panelPart2.Visible;
        }

    }
}
