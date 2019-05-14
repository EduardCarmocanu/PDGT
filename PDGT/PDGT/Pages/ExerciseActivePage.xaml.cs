using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDGT.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExerciseActivePage : ContentPage
	{
        
        public ExerciseActivePage ()
		{
			InitializeComponent ();

                      
            async void Animate(BoxView SetsDone)
            {
                do
                {
                    await Task.WhenAny<bool>
                       ( 
                        SetsDone.ScaleTo(1, 1000)
                        );
                    await SetsDone.ScaleTo(1.2, 1000);
                } while (true);
            }

            Animate(SetsDone);                                       
        }
               

        private async void GuideBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Viewguide());
        }

        private async void FinishSetBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SetFeedbackModal());
        }
    }
}