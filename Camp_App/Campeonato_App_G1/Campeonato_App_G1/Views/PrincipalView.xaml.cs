using Camp_App.ViewModels;
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
        PrincipalViewModel vm = new PrincipalViewModel();

        public PrincipalView()
        {
            InitializeComponent();
            this.BindingContext = vm;
        }

    }
}