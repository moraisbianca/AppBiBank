﻿using AppBancoDigital.Model;
using AppBancoDigital.Service;
using AppBancoDigital.View;
using AppBancoDigital.View.Popup;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
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
            btn_biometria.Source = ImageSource.FromResource("AppBancoDigital.Images.biometria.png");
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
                //throw new Exception("Insira o usuário e a senha!");

                //var page = new PopupErro();
                //page.BindingContext = Exception;

                //await PopupNavigation.PushAsync(page, true);
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

                        App.Current.MainPage = new NavigationPage(new Home());
                    }
                    else
                    {
                        //lbl_erro.Text = "Usuário ou senha incorretos!";
                        carregando.IsRunning = false;
                    }

                }
                catch (Exception ex)
                {
                    var page = new PopupErro();
                    page.BindingContext = ex;

                    await PopupNavigation.PushAsync(page, true);
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

        private async void btn_biometria_Clicked(object sender, EventArgs e)
        {
            bool supported = await CrossFingerprint.Current.IsAvailableAsync(true);
            if (supported)
            {
                AuthenticationRequestConfiguration conf = new AuthenticationRequestConfiguration("Bibank", "Acesse sua conta");
                var result = await CrossFingerprint.Current.AuthenticateAsync(conf);

                if (result.Authenticated)
                {
                    App.Current.MainPage = new NavigationPage(new Home());
                }
                else 
                {
                    string msg_erro = ("Biometria não reconhecida! Tente Novamente");
                    var page = new PopupErro();
                    page.BindingContext = msg_erro;

                    await PopupNavigation.PushAsync(page, true);
                }
            }
            else
            {
                string msg_erro = ("Desculpe! Este dispositivo não suporta esse método de autenticação");
                var page = new PopupErro();
                page.BindingContext = msg_erro;

                await PopupNavigation.PushAsync(page, true);
            }
        }
    }
}