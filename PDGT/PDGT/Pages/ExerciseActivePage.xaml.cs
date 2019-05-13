﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		}

        private async void GuideBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Viewguide());

        }

        private async void FinishSetBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FatiquePage());
        }
    }
}