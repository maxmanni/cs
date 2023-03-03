using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        Thread t;
        bool stop;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            int x;
            stop = false;
            //thread che esegue il controllo periodicamente
            t = new Thread(() =>
            {
                while (!stop)
                {
                    controllo();
                    Thread.Sleep(500);
                }
            });
            t.Start();
        }

        //funzione che controlla se il numero inserito é un intero
        void controllo()
        {
            int x;
            Debug.WriteLine("controllo(): textBox1.Text = " + textBox1.Text);
            //esempio di try parse
            if (Int32.TryParse(textBox1.Text, out x))
            {
                x = x + 1;
                //per poter cambiare il valore di una casella di testo da parte di un altro thread
                //(diverso dal thread che ha creato la casella) è necessario usare Invoke:
                //in questo modo è il form (nel thread principale) che esegue l'azione passata come
                //lamdba
                Invoke(()=>
                {
                    label1.Text = x.ToString();
                    textBox1.ForeColor = Color.Green;
                });

            }
            else
            {
                Invoke(() =>
                {
                    label1.Text = string.Empty;
                    textBox1.ForeColor = Color.Red;
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controllo();
        }

        //invocato al cambio di testo della textbox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //controllo();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string s = textBox1.Text;
            //esempio di try catch
            try
            {
                int i = Convert.ToInt32(s);
                MessageBox.Show("ok = " + i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("errore");
                Debug.WriteLine("errore = " + ex.ToString());
            }
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (t != null)
            {
                stop = true;
                t.Join();
                Debug.WriteLine("thread stopped");
            }
        }

    }
}