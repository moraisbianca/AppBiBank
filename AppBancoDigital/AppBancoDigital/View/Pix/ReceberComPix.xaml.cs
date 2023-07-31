using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReceberComPix : ContentPage
    {
        public ReceberComPix()
        {
            InitializeComponent();
            //btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.Images.seta-esquerda.png");
            //btn_interrogacao.Source = ImageSource.FromResource("AppBancoDigital.Images.ponto-de-interrogacao.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}