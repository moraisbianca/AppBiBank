using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View.Funcoes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Transferencias : ContentPage
	{
		public Transferencias()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }
	}
}