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

            if (txt_cpf.Text == null || txt_senha.Text == null)
            {
                lbl_erro.Text = "Insira o usuário e a senha!";
                carregando.IsRunning = false;
            }
            else
            {
                try
                {
                    Model.Correntista c = await DataServiceCorrentista.Entrar(new Model.Correntista
                    {
                        Senha = txt_senha.Text,
                        Cpf = txt_cpf.Text.Replace(".", string.Empty).Replace("-", string.Empty)
                    });

                    if (c.Id != null)
                    {
                        App.DadosCorrentista = c;

                        await Navigation.PushAsync(new Home());
                    }
                    else
                    {
                        lbl_erro.Text = "Usuário ou senha incorretos!";
                        carregando.IsRunning = false;
                    }

                }
                catch (Exception ex)
                {
                    await DisplayAlert("Ops", ex.Message, "OK");
                    Console.WriteLine(ex.StackTrace);
                }
                finally
                {
                    carregando.IsRunning = false;
                }
            }
        }


        private void btn_registrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Dados.Correntista());
        }

        private void esqueci_senha(object sender, EventArgs e)
        {

        }
    }
}