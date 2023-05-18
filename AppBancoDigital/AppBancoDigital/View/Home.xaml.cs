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

            txt_correntista.Text = App.DadosCorrentista.Nome;
        }

        private void ver_saldo(object sender, EventArgs e)
        {
            /*if (txt_saldo == "R$ 0,00")
            {
                txt_senha.IsPassword = false;
                btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.invisivel.png");
            }
            else
            {
                txt_senha.IsPassword = true;
                btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
            }*/
        }

        private void btn_menu_Clicked(object sender, EventArgs e)
        {

        }

    }
}