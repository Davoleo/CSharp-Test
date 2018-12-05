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

        public int GG
        {
            get { return gg; }

            set
            {
                if (value > 0 && value <= 31)
                    gg = value;
            }
        }

        public int MM
        {
            get { return mm; }

            set
            {
                if (value > 0 && value < 13)
                    mm = value;
            }
        }

        public int AAAA
        {
            get { return aaaa; }

            set {
                if(value > 1970)
                    aaaa = value;
            }
        }

        //Metodi

        //Costruttore di default
        public Date()
        {}

        public Date(int gg, int mm, int aaaa)
        {
            if (CheckDate(gg, mm, aaaa))
            {
                this.gg = gg;
                this.mm = mm;
                this.aaaa = aaaa;
            }
        }
        
        public int GetGiorno()
        {
            return gg;
        }

        public void SetGiorno(int gg)
        {
            if (gg > 0 && gg <= 31)
                gg = this.gg;
        }

        public static bool Bisestile(int anno)
        {
            return anno % 4 == 0;
        }

        public static int GiorniMese(int mese, int anno)
        {
            switch(mese)
            {
                case 2:
                    return Bisestile(anno) ? 29 : 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                    break;
                default:
                    return 31;
                    break;
            }
        }

        public static bool CheckDate(int gg, int mm, int aaaa)
        {
            if (gg < 1 || gg > 31 || mm < 1 || mm > 12 || aaaa < 1970)
                return false;
            else
                return gg <= GiorniMese(mm, aaaa);

            }

    }
}
