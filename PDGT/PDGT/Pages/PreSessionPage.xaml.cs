using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PDGT.Models;

namespace PDGT.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PreSessionPage : CarouselPage
	{
		public PreSessionPage ()
		{
            PreQuestionnaire myQ = new PreQuestionnaire();

			InitializeComponent ();
		}

        private void TakenPainKillers_Toggled(object sender, ToggledEventArgs e)
        {
            if(e.Value == true)
            {
                PainkillerTakenResult.Text = "Yes";
            }
            else
            {
                PainkillerTakenResult.Text = "No";
            }
        }

        private void Symptombs_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                SymptombsResult.Text = "Yes";
                SymptombsDescription.IsReadOnly = false;
                SymptombsDescription.BackgroundColor = Color.White;
                SymptombsDescription.Opacity = 1;
                SymptombsDescription.PlaceholderColor = Color.Black;
            }
            else
            {
                SymptombsResult.Text = "No";
                SymptombsDescription.IsReadOnly = true;
                SymptombsDescription.BackgroundColor = Color.FromHex("#CCCCCC");
                SymptombsDescription.Opacity = 0.5;
            }
        }

    }
}