using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Campeonato_App_G1.Models
{
    class Jogo
    {
        // Trocar qnd formos usar o banco para ser recebido os id's
        public string NomeSelecaoCasa { get; set; }
        public string NomeVisitante { get; set; }
        public int PlacarCasa { get; set; }
        public int PlacarVisitante { get; set; }
         public int PenaltisCasa { get; set; }
        public int PenaltisVisitante { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public string Estadio { get; set; }
        public string FotoCasa { get; set; }
        public string FotoVisitante { get; set; }

    }
}
