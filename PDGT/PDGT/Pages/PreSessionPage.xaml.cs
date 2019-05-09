﻿using System;
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
            //Call responsive methods on pages with comments
            SizeChanged += QuestionnaireCommentPage;
            SizeChanged += QuestionnaireSymptombsCommentPage;


            InitializeComponent ();
		}

        private void TakenPainKillers_Toggled(object sender, ToggledEventArgs e)
        {
            if(e.Value == true)
            {
                PainkillerTakenResult.Text = "Yes";
                PainkillerOptions.IsVisible = true;
            }
            else
            {
                PainkillerTakenResult.Text = "No";
                PainkillerOptions.IsVisible = false;
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

        //Make the Entry on the questionnaire "comment" page responsive according to the screenheight.
        void QuestionnaireCommentPage(Object sender, EventArgs e)
        {
            QuestionnaireComment.HeightRequest = Math.Min(this.Height, 275);
        }

        //Make the Entry on the questionnaire "symptombs" page responsive according to the screenheight.
        void QuestionnaireSymptombsCommentPage(Object sender, EventArgs e)
        {
            SymptombsDescription.HeightRequest = Math.Min(this.Height, 275);
        }

    }
}