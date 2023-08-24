using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
        public Home()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
			btn_menu.Source = ImageSource.FromResource("AppBancoDigital.Images.trespontos.png");
            btn_extrato.Source = ImageSource.FromResource("AppBancoDigital.Images.Extrato.png");
            btn_pix.Source = ImageSource.FromResource("AppBancoDigital.Images.Pix.png");
            btn_transferencias.Source = ImageSource.FromResource("AppBancoDigital.Images.Transacoes.png");
            btn_cartao.Source = ImageSource.FromResource("AppBancoDigital.Images.Cartoes.png");

            string[] resultsArray = explode(" ", App.DadosCorrentista.Nome);
            string nome = resultsArray[0];

            txt_correntista.Text = "Olá, " + nome;
        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }

        private void ver_saldo(object sender, EventArgs e)
        {
            /*if (txt_saldo = "")
            {
                btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Images.invisivel.png");
            }
            else
            {

                btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
            }*/
        }

        private void btn_menu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Menu());
        }

        private void btn_extrato_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Funcoes.Extrato());
        }

        private void btn_transferencias_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Funcoes.Transferencias());
        }

        private void btn_pix_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.HomePix());
        }

        private void btn_cartao_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Dados.Cartoes() );
        }

        private void btn_deslogar_Clicked(object sender, EventArgs e)
        {
            App.DadosCorrentista = null;

            Navigation.PushAsync(new Login());
        }
    }
}