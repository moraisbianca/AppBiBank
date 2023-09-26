using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Pix
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GerarQRCode : ContentPage
	{
		public GerarQRCode ()
		{
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.Images.seta-esquerda.png");
            btn_interrogacao.Source = ImageSource.FromResource("AppBancoDigital.Images.ponto-de-interrogacao.png");


            string teste = "Chave da Transferência: tiago@tiago.blog.br ";

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(teste, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);
            img_qrcode.Source = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        }

        private void btn_gerarQRCode_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_interrogacao_Clicked(object sender, EventArgs e)
        {

        }
    }
}