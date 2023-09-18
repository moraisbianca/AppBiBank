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
    public partial class Cartoes : ContentPage
    {
        public Cartoes()
        {
            InitializeComponent();
            btn_voltar.Source = ImageSource.FromResource("AppBancoDigital.Images.seta-esquerda.png");
            btn_interrogacao.Source = ImageSource.FromResource("AppBancoDigital.Images.ponto-de-interrogacao.png");

            btn_config_cartao_fisico.Source = ImageSource.FromResource("AppBancoDigital.Images.configuracao.png");
            bandeira_cartao_fisico.Source = ImageSource.FromResource("AppBancoDigital.Images.mastercard.png");

            bandeira_cartao_digital.Source = ImageSource.FromResource("AppBancoDigital.Images.mastercard.png");
            btn_config_cartao_digital.Source = ImageSource.FromResource("AppBancoDigital.Images.configuracao.png");
            codigo_qr.Source = ImageSource.FromResource("AppBancoDigital.Images.codigo-qr-cartao-virtual.png");

            NavigationPage.SetHasNavigationBar(this, false);

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

            nome_titular_digital.Text = nome_abreviado.ToUpper();
            nome_titular_fisico.Text = nome_abreviado.ToUpper();
        }

        public static string[] explode(string separator, string source)
        {
            return source.Split(new string[] { separator }, StringSplitOptions.None);
        }

        private void btn_voltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View.Home());
        }

        private void btn_interrogacao_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_config_cartao_fisico_Clicked(object sender, EventArgs e)
        {

        }

        private void btn_config_cartao_digital_Clicked(object sender, EventArgs e)
        {

        }
    }
}