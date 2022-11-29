using System.Diagnostics;
using System.IO;

namespace _05_ConfiguraTorta
{
    public partial class Form2 : Form
    {
        private Torta torta;

        public Form2()
        {
            InitializeComponent();
        }

        private void creaUnaNuovaTorta ()
        {
            torta = new Torta() //chiamo il costruttore e inizializzo le proprietà pubbliche 
            {
                Nome = "[nuova torta]",
                Copertura = TipoCopertura.NESSUNO,
                Farcitura = TipoFarcitura.NESSUNA,
                TemperaturaCottura = 0,
                TempoCottura = 0,
                VaCotta = false,
                NumeroStrati = 1
            };
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //carica valori possibili nella combobox Copertura
            comboCopertura.Items.Add(TipoCopertura.NESSUNO);
            comboCopertura.Items.Add(TipoCopertura.CIOCCOLATO);
            comboCopertura.Items.Add(TipoCopertura.ZUCCHERO_A_VELO);

            //carica valori possibili nella combobox Farcitura
            comboFarcitura.Items.Add(TipoFarcitura.NESSUNA);
            comboFarcitura.Items.Add(TipoFarcitura.MARMELLATA);
            comboFarcitura.Items.Add(TipoFarcitura.CREMA);

            //cra una nuova torta e carica i dati nei campi del form
            creaUnaNuovaTorta();
            carica_campi_da_oggetto();

            //evento per gestire il disegno
            panelDisegno.Paint += ridisegna;
        }

        private void carica_campi_da_oggetto ()
        {
            txtNome.Text = torta.Nome;
            checkVaCotta.Checked = torta.VaCotta;
            panelCottura.Enabled = torta.VaCotta;   
            txtTemperatura.Text = torta.TemperaturaCottura.ToString();
            txtTempo.Text = torta.TempoCottura.ToString();
            txtNumStrati.Text = torta.NumeroStrati.ToString();
            comboCopertura.SelectedIndex = (int) torta.Copertura;
            comboFarcitura.SelectedIndex = (int) torta.Farcitura;
        }

        private Torta crea_oggetto_da_campi ()
        {
            creaUnaNuovaTorta();
            torta.Nome = txtNome.Text;
            torta.VaCotta = checkVaCotta.Checked;
            if (torta.VaCotta)
            {
                torta.TemperaturaCottura = Convert.ToSingle(txtTemperatura.Text);
                torta.TempoCottura = Convert.ToSingle(txtTempo.Text);
            }
            torta.NumeroStrati = Convert.ToInt32(txtNumStrati.Text);
            torta.Copertura = (TipoCopertura) comboCopertura.SelectedIndex;
            torta.Farcitura = (TipoFarcitura) comboFarcitura.SelectedIndex;
            return torta;
        }

        private void pulisciCampi_Click(object sender, EventArgs e)
        {
            //cra una nuova torta e carica i dati nei campi del form
            creaUnaNuovaTorta();
            carica_campi_da_oggetto();
        }

        private void checkVaCotta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVaCotta.Checked)
            {
                panelCottura.Enabled = true;
            } else
            {
                panelCottura.Enabled = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            torta = crea_oggetto_da_campi();
            torta.ScriviSuFile(txtNomeFile.Text);
            MessageBox.Show(string.Format("{0} salvato correttamente", txtNomeFile.Text), "Salva file", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            torta = new Torta();
            if (torta.LeggiDaFile(txtNomeFile.Text))
            {
                carica_campi_da_oggetto();
                MessageBox.Show(string.Format("{0} caricato correttamente", txtNomeFile.Text), "Apri file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show(string.Format("Il file {0} non esiste", txtNomeFile.Text), "Apri file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileNotepad_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtNomeFile.Text))
            {
                Process p = new Process();
                p.StartInfo.FileName = "notepad.exe";
                p.StartInfo.Arguments = txtNomeFile.Text;
                p.Start();
            }
            else
            {
                MessageBox.Show(string.Format("Il file {0} non esiste", txtNomeFile.Text), "Apri file", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool disegnaClicked = false;
        private void buttonDisegna_Click(object sender, EventArgs e)
        {
            crea_oggetto_da_campi();
            disegnaClicked = true;
            panelDisegno.Invalidate();
        }


        const float larghezzaStrato = 100.0f;
        const float altezzaStrato = 10.0f;
        const float altezzaFarcitura = 5.0f;
        const float yPartenzaTorta = 0.0f;

        private void ridisegna(object? sender, PaintEventArgs e)
        {
            if (disegnaClicked)
            {
                Graphics g = e.Graphics;

                //sposta origine delle coordinate al centro del pannello e flippa l'asse y
                g.TranslateTransform((float)panelDisegno.Width / 2.0f, (float)panelDisegno.Height / 2.0f);
                g.ScaleTransform(1.0f, -1.0f);

                g.Clear(panelDisegno.BackColor);
                //test line
                //g.DrawLine(Pens.Red, 0.0f, 0.0f, (float)panelDisegno.Width /2 , (float)panelDisegno.Height/2 );


                //copertura
                Brush brushCopertura = Brushes.LightYellow;
                switch(torta.Copertura)
                {
                    case TipoCopertura.CIOCCOLATO:
                        brushCopertura = Brushes.Brown;
                        break;
                    case TipoCopertura.ZUCCHERO_A_VELO:
                        brushCopertura = Brushes.LightBlue;
                        break;
                }

                //farcitura
                Brush brushFarcitura = Brushes.LightYellow;
                switch (torta.Farcitura)
                {
                    case TipoFarcitura.MARMELLATA:
                        brushFarcitura = Brushes.Orange;
                        break;
                    case TipoFarcitura.CREMA:
                        brushFarcitura = Brushes.Yellow;
                        break;
                }


                float y = yPartenzaTorta;
                for (int i=0;i<torta.NumeroStrati;i++)
                {
                    //disegna strato
                    g.FillRectangle(brushCopertura, -larghezzaStrato / 2, y, larghezzaStrato, altezzaStrato);
                    y += altezzaStrato;

                    //disegna farcitura (se c'e')
                    if (i < torta.NumeroStrati-1 && (torta.Farcitura != TipoFarcitura.NESSUNA))
                    {
                        g.FillRectangle(brushFarcitura, -larghezzaStrato / 2, y, larghezzaStrato, altezzaFarcitura);
                        y += altezzaFarcitura;
                    }
                }

                //disegna stringa cottura
                var gc = g.BeginContainer();
                g.ScaleTransform(1.0f, -1.0f);
                g.DrawString(torta.StringaCottura, panelDisegno.Font, Brushes.Black, new PointF(-50, 20));
                g.EndContainer(gc);

                disegnaClicked = false;
            }
           
        }
    }
}