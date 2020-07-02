using Campeonato_App_G1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato_App_G1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CadastroView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
