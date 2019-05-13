using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDGT.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FatiquePage : ContentPage
	{
		public FatiquePage ()
		{
			InitializeComponent ();
		}

        private async void ContinueBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ExerciseActivePage());
        }
    }
}