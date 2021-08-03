using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polideportivo.Modelo
{
    class modeloTipoCampeonato
    {
        public int pkId { get; set; }
        public string tipo { get; set; }

        public modeloTipoCampeonato() { }

        public modeloTipoCampeonato(int Id, string Tipo)
        {
            pkId = Id;
            tipo = Tipo;
        }
    }
}
