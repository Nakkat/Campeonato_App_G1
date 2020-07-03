using Campeonato_App_G1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato_App_G1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalView : ContentPage
    {
        IList<Jogo> Jogos { get; set; }
        public PrincipalView()
        {
            InitializeComponent();

            Jogos = new List<Jogo>();

            Jogos.Add(new Jogo
            {
                Data = Convert.ToDateTime("08/07/2014"),
                Estadio = "Arena Fonte Nova",
                NomeSelecaoCasa = "Holanda",
                NomeVisitante = "Costa Rica",
                PlacarCasa = 0,
                PlacarVisitante = 0,
                PenaltisCasa = 4,
                PenaltisVisitante = 3,
                FotoCasa = "Holanda_Bandeira.jpg",
                FotoVisitante = "Costa_rica_Bandeira.jpg"
            });
            Jogos.Add(new Jogo
            {
                Data = Convert.ToDateTime("08/07/2014"),
                Estadio = "Mineirão",
                NomeSelecaoCasa = "Brasil",
                NomeVisitante = "Alemanha",
                PlacarCasa = 1,
                PlacarVisitante = 7,
                FotoCasa = "Brasil_Bandeira.jpg",
                FotoVisitante = "Alemanha_Bandeira.jpg"
            });
            BindingContext = this;  
        }

    }
}