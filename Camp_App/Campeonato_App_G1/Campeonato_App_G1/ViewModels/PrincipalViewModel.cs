using Campeonato_App_G1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp_App.ViewModels
{
    
    class PrincipalViewModel
    {
        public List<Jogo> jogos { get; set; }
        public PrincipalViewModel()
        {
            jogos = new List<Jogo>();

            jogos = new List<Jogo>
            {
                new Jogo
                {
                    id = 1,
                    estadio = "mineirão",
                    data  = DateTime.Now,
                    placarCasa = 7,
                    placarVisitante = 1,
                    penaltisCasa = 0,
                    penaltisVisitante = 0,
                    selecaoCasa = 1,
                    selecaoVisitante = 2
                },
                new Jogo
                {
                    id = 2,
                    estadio = "mineirão",
                    data  = new DateTime(2020,07,05),
                    placarCasa = 6,
                    placarVisitante = 1,
                    penaltisCasa = 0,
                    penaltisVisitante = 0,
                    selecaoCasa = 1,
                    selecaoVisitante = 2
                }
            };
        }
    }
}
