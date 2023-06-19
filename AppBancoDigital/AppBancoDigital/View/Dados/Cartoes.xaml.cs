using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Dados
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cartoes : ContentPage
    {
        public Cartoes()
        {
            InitializeComponent();
            btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.Images.seta-esquerda.png");
            btn_interrogacao.Source = ImageSource.FromResource("AppBancoDigital.Images.ponto-de-interrogacao.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Home());
        }

        private void btn_interrogacao_Clicked(object sender, EventArgs e)
        {

        }
    }
}