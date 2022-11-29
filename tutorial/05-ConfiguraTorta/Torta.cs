using System;
using System.IO;

namespace _05_ConfiguraTorta
{
    public enum TipoCopertura
    {
        NESSUNO, CIOCCOLATO, ZUCCHERO_A_VELO
    }

    public enum TipoFarcitura
    {
        NESSUNA, MARMELLATA, CREMA
    }

    public class Torta
    {
        public string Nome { get; set; }
        public bool VaCotta { get; set; }
        public float TemperaturaCottura { get; set; }
        public float TempoCottura { get; set; }

        public string StringaCottura
        {
            get
            {
                if (VaCotta)
                {
                    return string.Format("Va cotta a {0}°C per {1} min.", TemperaturaCottura, TempoCottura);
                } else
                {
                    return "Non va cotta";
                }
                
            }
        }

        public int NumeroStrati { get; set; }

        public TipoCopertura Copertura {get; set;}
        public TipoFarcitura Farcitura {get; set;}

        public Torta()
        {
            Nome = string.Empty;
            VaCotta = false;
            TemperaturaCottura = 0;
            TempoCottura = 0;
            NumeroStrati = 1;
            Copertura = TipoCopertura.NESSUNO;
            Farcitura = TipoFarcitura.NESSUNA;
        }

        public override string ToString()
        {
            return string.Format("Nome={0};VaCotta={1};TemperaturaCottura={2};TempoCottura={3};NumeroStrati={4};Copertura={5};Farcitura={6}", 
                                    Nome, VaCotta, TemperaturaCottura, TempoCottura,
                                    NumeroStrati, (int)Copertura, (int)Farcitura
                   );
        }

        public void Parse (string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                string[] elenco = s.Split(";");
                foreach (string p in elenco)
                {
                    string[] coppiaNomeValore = p.Split("=");
                    string nomeProprieta = coppiaNomeValore[0];
                    string valoreProprieta = coppiaNomeValore[1];
                    switch (nomeProprieta)
                    {
                        case "Nome":
                            Nome = valoreProprieta;
                            break;
                        case "VaCotta":
                            VaCotta = Convert.ToBoolean(valoreProprieta);
                            break;
                        case "TemperaturaCottura":
                            TemperaturaCottura = Convert.ToSingle(valoreProprieta);    
                            break;
                        case "TempoCottura":
                            TempoCottura = Convert.ToSingle(valoreProprieta);
                            break;
                        case "NumeroStrati":
                            NumeroStrati = Convert.ToInt32(valoreProprieta);  
                            break;
                        case "Copertura":
                            Copertura = (TipoCopertura) Convert.ToInt32(valoreProprieta);
                            break;
                        case "Farcitura":
                            Farcitura = (TipoFarcitura) Convert.ToInt32(valoreProprieta);
                            break;
                    }
                }
            }
        }

        public void ScriviSuFile (string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(this);
            }
        }

        public void LeggiDaFile (string path)
        {
            string s = File.ReadAllText(path);
            Parse(s);
        }
    }
}
