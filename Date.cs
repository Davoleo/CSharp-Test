using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Test
{
    class Date
    {
        //Stato Interno
        int gg = 1, mm = 1, aaaa = 1970;

        //Propietà
        //Variabili fantasma che permettono di accedere in modo diretto alle variabili dello stato interno
        //senza rinunciare ai controlli e alla sicurezza
        //value è il valore inserito nella proprietà
        public int MM
        {
            get { return mm; }

            set
            {
                if (value > 0 && value < 13)
                    mm = value;
            }
        }

        //Metodi

        //Costruttore di default
        public Date()
        {}
        
        public int GetGiorno()
        {
            return gg;
        }

        public void SetGiorno(int gg)
        {
            if (gg > 0 && gg <= 31)
                gg = this.gg;
        }

    }
}
