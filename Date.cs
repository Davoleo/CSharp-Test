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

        //Proprietà di controllo del giorno
        public int GG
        {
            get { return gg; }

            set
            {
                if (value > 0 && value <= 31)
                    gg = value;
            }
        }

        //Proprietà di controllo del mese
        public int MM
        {
            get { return mm; }

            set
            {
                if (value > 0 && value < 13)
                    mm = value;
            }
        }

        //Proprietà di controllo dell'anno
        public int AAAA
        {
            get { return aaaa; }

            set {
                if (value > 1970)
                    aaaa = value;
            }
        }

        //Metodi

        //Costruttore di default
        public Date()
        { }

        //Permette di creare una data
        public Date(int gg, int mm, int aaaa)
        {
            if (CheckDate(gg, mm, aaaa))
            {
                this.gg = gg;
                this.mm = mm;
                this.aaaa = aaaa;
            }
        }

        //Restituisce il giorno impostato
        public int GetGiorno()
        {
            return gg;
        }

        //Imposta un giorno nella data
        public void SetGiorno(int gg)
        {
            if (gg > 0 && gg <= 31)
                gg = this.gg;
        }

        //Restituisce se un anno è bisestile
        public static bool Bisestile(int anno)
        {
            return anno % 4 == 0;
        }

        //Restituisce il numero di giorni di un mese in un certo anno
        public static int GiorniMese(int mese, int anno)
        {
            switch (mese)
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

        //Controlla se la data è scritta in un formato valido
        public static bool CheckDate(int gg, int mm, int aaaa)
        {
            if (gg < 1 || gg > 31 || mm < 1 || mm > 12 || aaaa < 1970)
                return false;
            else
                return gg <= GiorniMese(mm, aaaa);

        }

        //Aggiunge un certo numero di giorni alla data
        public void Incrementa(int giorni)
        {
            for (int i = 0; i < giorni; i++)
            {
                gg++;

                if (gg > GiorniMese(mm, aaaa))
                {
                    mm++;
                    gg = 1;

                    if (mm > 12)
                    {
                        aaaa++;
                        mm = 1;
                    }
                }
            }
        }


        //Toglie un certo numero di giorni alla data
        public void Decrementa(int giorni)
        {
            for (int i = 0; i < giorni; i++)
            {
                gg--;

                if (gg < 1)
                {
                    mm--;

                    if (mm < 1)
                    {
                        aaaa--;
                        mm = 12;
                    }

                    gg = GiorniMese(mm, aaaa);
                }
            }
        }

        //Overload dell'operatore ++ per aggiungere un giorno ad una data
        public static Date operator ++(Date d)
        {
            d.Incrementa(1);
            return d;
        }

        //Overload dell'operatore + per sommare un intero ad una data
        public static Date operator +(Date d, int giorni)
        {
            if (giorni >= 0)
                for (int i = 0; i < giorni; i++)
                    d.Incrementa(1);
            else
                for (int i = 0; i < -giorni; i++)
                    d.Decrementa(1);
            return d;
        }

        //Overload dell'operatore -- per togliere un giorno ad una data
        public static Date operator --(Date d)
        {
            d.Decrementa(1);
            return d;
        }

        //Override del metodo ToString applicato alla classe e al formato delle date
        public override string ToString()
        {
            return gg.ToString() + "-" + mm.ToString() + "-" + aaaa.ToString(); 
        }

    }
}
