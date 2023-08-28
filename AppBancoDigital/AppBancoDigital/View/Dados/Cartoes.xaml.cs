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
            btn_config_cartao_fisico.Source = ImageSource.FromResource("AppBancoDigital.Images.configuracao.png");
            bandeira_cartao_fisico.Source = ImageSource.FromResource("AppBancoDigital.Images.mastercard.png");
            btn_config_cartao_digital.Source = ImageSource.FromResource("AppBancoDigital.Images.configuracao.png");
            bandeira_cartao_digital.Source = ImageSource.FromResource("AppBancoDigital.Images.mastercard.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Home());
        }

        private void btn_interrogacao_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_config_cartao_fisico_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_config_cartao_digital_Clicked(object sender, EventArgs e)
        {

        }
    }
}