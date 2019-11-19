using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempovida
{
    class tempo
    {
        private DateTime tempodevida = new D

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
                return "O dia da semana em que você nasceu foi " + tempodevida.ToString("g");
            }
        }
    }
}
