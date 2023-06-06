using AppBancoDigital.Model;
using AppBancoDigital.Service;
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
	public partial class Correntista : ContentPage
	{
		public Correntista ()
		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar(this,false);
            dtpck_datanasc.MaximumDate = DateTime.Now.AddYears(-16);
            btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
            btn_confirme_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
        }

        private async void continuar(object sender, EventArgs e)
        {    
            try
            {

                Model.Correntista c = await DataServiceCorrentista.Cadastrar(new Model.Correntista
                {
                    Nome = txt_nome.Text,
                    Senha = txt_senha.Text,
                    DataNasc = dtpck_datanasc.Date,
                    Cpf = txt_cpf.Text.Replace(".", string.Empty).Replace("-", string.Empty)
                });

                string msg = $"Correntista criado! Faça login para acessar.";

                await DisplayAlert("Sucesso!", msg, "OK");

                await Navigation.PushAsync(new Login());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void ver_senha(object sender, EventArgs e)
        {
            if (txt_senha.IsPassword == true)
            {
                txt_senha.IsPassword = false;
                btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.invisivel.png");
            }
            else
            {
                txt_senha.IsPassword = true;
                btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
            }
        }

        private void ver_confirme_senha(object sender, EventArgs e)
        {
            if (txt_confirme_senha.IsPassword == true)
            {
                txt_confirme_senha.IsPassword = false;
                btn_confirme_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.invisivel.png");
            }
            else
            {
                txt_confirme_senha.IsPassword = true;
                btn_confirme_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
            }
        }
    }
}