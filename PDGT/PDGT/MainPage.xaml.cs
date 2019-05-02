using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PDGT.Pages;

namespace PDGT
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PreSessionPage());
        }
    }
}
