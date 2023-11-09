using QRCoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Pix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReceberComPix : ContentPage
    {
        public ReceberComPix()
        {
            InitializeComponent();
            btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.Images.seta-esquerda.png");
            btn_interrogacao.Source = ImageSource.FromResource("AppBancoDigital.Images.ponto-de-interrogacao.png");
            NavigationPage.SetHasNavigationBar(this, false);


            string CpfOculto = Regex.Replace(App.DadosCorrentista.Cpf, "([0-9]{3}).([0-9]{3}).([0-9]{3})-([0-9]{2})", "$1.*.*.*-$4");
            txt_cpf.Text = FormatCPF(CpfOculto);


            string[] resultsArray = explode(" ", App.DadosCorrentista.Nome);
            string primeiro_nome = resultsArray[0];
            string nome_meio = " ";
            string sobrenome = resultsArray[0];

            for (int i = 1; i < resultsArray.Length - 1; i++)
            {
                if (!resultsArray[i].ToLower().Equals("de") && !resultsArray[i].ToLower().Equals("da") && !resultsArray[i].ToLower().Equals("do") && !resultsArray[i].ToLower().Equals("das") && !resultsArray[i].ToLower().Equals("dos"))
                {
                    nome_meio += resultsArray[i].Substring(0, 1); // Reserva a inicial do próximo nome.
                    nome_meio += ". "; // Põe um ponto e um espaço após a inicial.
                }
            }

            sobrenome = resultsArray[resultsArray.Length - 1]; // Reserva o ultimo nome.

            string nome_abreviado = primeiro_nome + nome_meio + sobrenome; // Junta todos os nomes.

            txt_nome.Text = nome_abreviado;
        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }

        public string FormatCPF(string sender)
        {
            string response = sender.Trim();
            if (response.Length == 11)
            {
                response = response.Insert(9, "-");
                response = response.Insert(6, ".");
                response = response.Insert(3, ".");
            }
            return response;

        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.HomePix());
        }

        private void btn_interrogacao_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Pix.GerarQRCode());
        }
    }
}