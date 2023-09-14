using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePix : ContentPage
    {
        public HomePix()
        {
            InitializeComponent();
            btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.Images.seta-esquerda.png");
            btn_interrogacao.Source = ImageSource.FromResource("AppBancoDigital.Images.ponto-de-interrogacao.png");
            btn_pagar_pix.Source = ImageSource.FromResource("AppBancoDigital.Images.Pagar.png");
            btn_receber_pix.Source = ImageSource.FromResource("AppBancoDigital.Images.Receber.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btn_interrogacao_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Home());
        }

        private void btn_pagar_pix_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.PagarComPix());
        }

        private void btn_receber_pix_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.ReceberComPix());
        }
    }
}