using AppBancoDigital.Model;
using AppBancoDigital.Service;
using AppBancoDigital.View.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static AppBancoDigital.App;
using static ZXing.QrCode.Internal.Mode;

namespace AppBancoDigital.View.Dados
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Correntista : ContentPage
    {
        public Correntista()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            dtpck_datanasc.MaximumDate = DateTime.Now.AddYears(-16);
            btn_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");
            btn_confirme_senha.Source = ImageSource.FromResource("AppBancoDigital.Images.visivel.png");

        }

        private async void continuar(object sender, EventArgs e)
        {
            try
            {
                if (txt_senha.Text != txt_confirme_senha.Text)
                {
                    throw new Exception("A senha deve ser a mesma nos dois campos!");
                }

                Model.Correntista c = await DataServiceCorrentista.Cadastrar(new Model.Correntista
                {
                    Nome = txt_nome.Text,
                    Senha = txt_senha.Text,
                    DataNasc = dtpck_datanasc.Date,
                    Cpf = txt_cpf.Text
                });

                var page = new PopupSucesso();

                await PopupNavigation.Instance.PushAsync(page);

                await Navigation.PushAsync(new Login());
            }
            catch (Exception ex)
            {

                var page = new PopupErro();
                page.BindingContext = ex;

                await PopupNavigation.PushAsync(page, true);
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