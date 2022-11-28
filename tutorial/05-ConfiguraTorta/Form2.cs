namespace _05_ConfiguraTorta
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private Torta creaUnaNuovaTorta ()
        {
            Torta nuovaTorta = new Torta() //chiamo il costruttore e inizializzo le proprietà pubbliche 
            {
                Nome = "[nuova torta]",
                Copertura = TipoCopertura.NESSUNO,
                Farcitura = TipoFarcitura.NESSUNA,
                TemperaturaCottura = 0,
                TempoCottura = 0,
                VaCotta = false,
                NumeroStrati = 1
            };
            return nuovaTorta;
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
            Torta t = creaUnaNuovaTorta();
            carica_campi_da_oggetto(t);
        }

        private void carica_campi_da_oggetto (Torta t)
        {
            txtNome.Text = t.Nome;
            checkVaCotta.Checked = t.VaCotta;
            panelCottura.Enabled = t.VaCotta;   
            txtTemperatura.Text = t.TemperaturaCottura.ToString();
            txtTempo.Text = t.TempoCottura.ToString();
            txtNumStrati.Text = t.NumeroStrati.ToString();
            comboCopertura.SelectedIndex = (int) t.Copertura;
            comboFarcitura.SelectedIndex = (int) t.Farcitura;
        }

        private Torta crea_oggetto_da_campi ()
        {
            Torta t = creaUnaNuovaTorta();
            t.Nome = txtNome.Text;
            t.VaCotta = checkVaCotta.Checked;
            if (t.VaCotta)
            {
                t.TemperaturaCottura = Convert.ToSingle(txtTemperatura.Text);
                t.TempoCottura = Convert.ToSingle(txtTempo.Text);
            }
            t.NumeroStrati = Convert.ToInt32(txtNumStrati.Text);
            t.Copertura = (TipoCopertura) comboCopertura.SelectedIndex;
            t.Farcitura = (TipoFarcitura) comboFarcitura.SelectedIndex;
            return t;
        }

        private void pulisciCampi_Click(object sender, EventArgs e)
        {
            //cra una nuova torta e carica i dati nei campi del form
            Torta t = creaUnaNuovaTorta();
            carica_campi_da_oggetto(t);
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
            Torta t = crea_oggetto_da_campi();
            t.ScriviSuFile(txtNomeFile.Text);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            Torta t = new Torta();  
            t.LeggiDaFile(txtNomeFile.Text);
            carica_campi_da_oggetto(t);
        }
    }
}