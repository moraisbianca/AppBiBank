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

            string[] resultsArray = explode(" ", App.DadosCorrentista.Nome);
            string nome = resultsArray[0];
            txt_correntista.Text = "Olá, " + nome;
        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }
    }
}