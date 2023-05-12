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
	public partial class Correntista : ContentPage
	{
		public Correntista ()
		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar(this,false);
            dtpck_datanasc.MaximumDate = DateTime.Now.AddYears(-16);
            btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
            btn_confirme_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.invisivel.png");
        }

        private void continuar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void ver_senha(object sender, EventArgs e)
        {
            if (txtpassword.IsPassword == true)
            {
                txtpassword.IsPassword = false;
                btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.invisivel.png");
            }
            else
            {
                txtpassword.IsPassword = true;
                btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
            }
        }

        private void ver_confirme_senha(object sender, EventArgs e)
        {
            if (txtconfirmpassword.IsPassword == true)
            {
                txtconfirmpassword.IsPassword = false;
                btn_confirme_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.invisivel.png");
            }
            else
            {
                txtconfirmpassword.IsPassword = true;
                btn_confirme_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
            }
        }
    }
}