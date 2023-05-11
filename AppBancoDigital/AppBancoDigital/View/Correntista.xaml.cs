using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBancoDigital.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Correntista : ContentPage
	{
		public Correntista ()
		{
			InitializeComponent ();
			NavigationPage.SetHasNavigationBar(this,false);
            dtpck_datanasc.MaximumDate = DateTime.Now.AddYears(-16);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}