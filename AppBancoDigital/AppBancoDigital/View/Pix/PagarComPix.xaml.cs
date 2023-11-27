using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;
using System.Drawing;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagarComPix : ContentPage
    {
        public PagarComPix()
        {
            InitializeComponent();
            btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.Images.seta-esquerda.png");
            btn_interrogacao.Source = ImageSource.FromResource("AppBancoDigital.Images.ponto-de-interrogacao.png");
            btn_qrcode.Source = ImageSource.FromResource("AppBancoDigital.Images.qr.png");
            btn_pix_copia_cola.Source = ImageSource.FromResource("AppBancoDigital.Images.copiando.png");
            btn_agencia_conta.Source = ImageSource.FromResource("AppBancoDigital.Images.cartao-de-credito (1).png");

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.HomePix());
        }
        private void btn_interrogacao_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_qrcode_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LerQRCode());
        }

        private void btn_pix_copia_cola_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_agencia_conta_Clicked(object sender, EventArgs e)
        {

        }
    }
}