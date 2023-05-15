using AppBancoDigital.Model;
using AppBancoDigital.Service;
using AppBancoDigital.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
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

        private async void btn_entrar(object sender, EventArgs e)
        {
            
            carregando.IsRunning = true;
            try
            {
                Model.Correntista c = await DataServiceCorrentista.Entrar(new Model.Correntista
                {
                    Senha = txt_senha.Text,
                    Cpf = txt_cpf.Text
                });

                if (c.Id != 0)
                {
                    string msg = $"O login foi feito com sucesso";

                    await DisplayAlert("Bem vindo!", msg, "OK");

                    await Navigation.PushAsync(new Home());
                }
                else
                {
                    string msg = $"Algo deu errado, tente logar novamente!";

                    await DisplayAlert("Erro!", msg, "OK");

                    await Navigation.PushAsync(new Login());
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
            finally
            {
                carregando.IsRunning = false;
            }
        }

        private void btn_registrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Correntista());
        }

    }
}