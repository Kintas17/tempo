using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempovida
{
    class tempo
    {
        private DateTime tempodevida;

        public string recebe
        {
            set
            {
                tempodevida = Convert.ToDateTime(value);
            }
        }
        public string envia
        {
            get
            {
                DateTime hoje = DateTime.Now;
                int anos = hoje.Year - tempodevida.Year;
                int meses = hoje.Month - tempodevida.Month;
                int dias = hoje.Day - tempodevida.Day;
                string frase = "A sua idade é ";
                if (meses < 0)
                {
                    anos--;
                    meses += 12;
                }
                if (dias<0)
                {
                    meses--;
                    dias += 30;
                }
                frase += anos.ToString() + " anos ";
                frase += meses.ToString() + " meses e ";
                frase += dias.ToString() + " dias ";
                return frase;
            }
        }
    }
}
