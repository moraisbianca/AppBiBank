using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupMenu : PopupPage
    {
        public PopupMenu()
        {
            InitializeComponent();
            Barrinha.Source = ImageSource.FromResource("AppBancoDigital.Images.barrinha.png");
            btn_setinha_1.Source = ImageSource.FromResource("AppBancoDigital.Images.seta-direita.png");
            btn_setinha_2.Source = ImageSource.FromResource("AppBancoDigital.Images.seta-direita.png");
            btn_setinha_3.Source = ImageSource.FromResource("AppBancoDigital.Images.seta-direita.png");
            btn_avatar.Source = ImageSource.FromResource("AppBancoDigital.Images.avatar.png");
            btn_notificacoes.Source = ImageSource.FromResource("AppBancoDigital.Images.notificacao.png");
            btn_deslogar.Source = ImageSource.FromResource("AppBancoDigital.Images.sair.png");

            string[] resultsArray = explode(" ", App.DadosCorrentista.Nome);
            string nome = resultsArray[0];
            txt_correntista.Text = "Olá, " + nome;
        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }

        private void btn_avatar_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_notificacoes_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_deslogar_Clicked(object sender, EventArgs e)
        {

        }
    }
}