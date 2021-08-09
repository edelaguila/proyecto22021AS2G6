using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.DTO
{
    public class dtoTipoFalta
    {
        public int pkId { get; set; }
        public string tipo { get; set; }
        public int fkIdDeporte { get; set; }

        public dtoTipoFalta()
        {
        }

        public dtoTipoFalta(int Id, string Tipo, int IdDeporte)
        {
            pkId = Id;
            tipo = Tipo;
            fkIdDeporte = IdDeporte;
        }
    }
}