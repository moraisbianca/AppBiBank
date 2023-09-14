using AppBancoDigital.View.Popup;
using Rg.Plugins.Popup.Services;
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
            btn_lupa.Source = ImageSource.FromResource("AppBancoDigital.Images.lupa.png");
            btn_pix.Source = ImageSource.FromResource("AppBancoDigital.Images.Pix.png");
            btn_transferencias.Source = ImageSource.FromResource("AppBancoDigital.Images.Transacoes.png");
            btn_cartao.Source = ImageSource.FromResource("AppBancoDigital.Images.Cartoes.png");
        }

        private void ver_saldo(object sender, EventArgs e)
        {
            double saldo_contas = App.DadosCorrentista.rows_contas.Sum(i => i.Saldo);

            if (txt_saldo.Text == "R$ ")
            {
                txt_saldo.Text = "R" + saldo_contas.ToString("C");
                btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Images.invisivel.png");
            }
            else
            {
                txt_saldo.Text = "R$ ";
                btn_saldo.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
            }
        }

        private async void btn_menu_Clicked(object sender, EventArgs e)
        {
            var page = new PopupMenu();

            await PopupNavigation.PushAsync(page, true);
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
            Navigation.PushAsync(new View.Dados.Cartoes());
        }


        private void btn_lupa_Clicked(object sender, EventArgs e)
        {
            // Fazer funcionalidade da pesquisa
        }
    }
}