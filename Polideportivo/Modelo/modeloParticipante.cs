using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modeloParticipante
    {
        public int pkId { get; set; }
        public int puntos { get; set; }
        public string estado { get; set; }
        public int fkIdCampeonato { get; set; }
        public int fkIdEquipo { get; set; }
        public int fkIdFase { get; set; }

        public modeloParticipante()
        {
        }

        public modeloParticipante(int pkId, int puntos, string estado, int fkIdCampeonato, int fkIdEquipo, int fkIdFase)
        {
            this.pkId = pkId;
            this.puntos = puntos;
            this.estado = estado;
            this.fkIdCampeonato = fkIdCampeonato;
            this.fkIdEquipo = fkIdEquipo;
            this.fkIdFase = fkIdFase;
        }
    }
}