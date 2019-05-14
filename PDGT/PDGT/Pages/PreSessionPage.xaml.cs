using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDGT.Stores;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PDGT.Models;

namespace PDGT.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PreSessionPage : CarouselPage
	{
        //Instantiate the PreQuestionnaire model to be used
        PreQuestionnaire PreQuestions = new PreQuestionnaire();

        public PreSessionPage ()
		{
            //Call responsive methods on pages with comments
            SizeChanged += QuestionnaireCommentPage;
            SizeChanged += QuestionnaireSymptombsCommentPage;

            InitializeComponent ();
            //Add list of painkillers. Work's in code-behind, but not in XAML Markup ¯\_(ツ)_/¯
            var PainkillerName = new List<Painkiller>();
            PainkillerName.Add(new Painkiller { TakenPainkillers = "Panodil" });
            PainkillerName.Add(new Painkiller { TakenPainkillers = "Ipren" });
            PainkillerName.Add(new Painkiller { TakenPainkillers = "Pamol" });

            PainkillerList.ItemsSource = PainkillerName;
            PainkillerList.ItemDisplayBinding = new Binding("Type");

            //Bind comment to PreQuestionnaire model
            QuestionnaireComment.Text = PreQuestions.Comments;
        }

        private void TakenPainKillers_Toggled(object sender, ToggledEventArgs e)
        {
            if(e.Value == true)
            {
                PainkillerTakenResult.Text = "Yes";
                PainkillerOptions.IsVisible = true;
                //Prequestionnaire  Painkiller model
                PreQuestions.TakenPainkillers = true;
            }
            else
            {
                PainkillerTakenResult.Text = "No";
                PainkillerOptions.IsVisible = false;
                //Prequestionnaire  Painkiller model
                PreQuestions.TakenPainkillers = false;
            }
        }

        //If symptoms is toggled allow comments.
        private void Symptombs_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                SymptombsResult.Text = "Yes";
                SymptombsDescription.IsReadOnly = false;
                SymptombsDescription.BackgroundColor = Color.White;
                SymptombsDescription.Opacity = 1;
                SymptombsDescription.PlaceholderColor = Color.Black;
                //Prequestionnaire model
                PreQuestions.TrainingSideEffects = true;
                PreQuestions.TrainingSideEffectsDescription = SymptombsDescription.Text;
            }
            else
            {
                SymptombsResult.Text = "No";
                SymptombsDescription.IsReadOnly = true;
                SymptombsDescription.BackgroundColor = Color.FromHex("#CCCCCC");
                SymptombsDescription.Opacity = 0.5;
                //Prequestionnaire model
                PreQuestions.TrainingSideEffects = false;
            }
        }

        //Make the Entry on the questionnaire "comment" page responsive according to the screenheight.
        void QuestionnaireCommentPage(Object sender, EventArgs e)
        {
            QuestionnaireComment.HeightRequest = Math.Min(this.Height, 150);
        }

        //Make the Entry on the questionnaire "symptombs" page responsive according to the screenheight.
        void QuestionnaireSymptombsCommentPage(Object sender, EventArgs e)
        {
            SymptombsDescription.HeightRequest = Math.Min(this.Height, 150);
        }

        private void CarouselForward(object sender, EventArgs e)
        {
            int carouselIndex = Children.IndexOf(CurrentPage);
            this.CurrentPage = this.Children[carouselIndex + 1];
        }

        private void CarouselBackward(object sender, EventArgs e)
        {
            int carouselIndex = Children.IndexOf(CurrentPage);
            this.CurrentPage = this.Children[carouselIndex - 1];
        }

        private async void StartExerciseSession(object sender, EventArgs e)
        {
            QuestionnaireStore.SetPreQuestionnaireAsync(PreQuestions);
            await Navigation.PushAsync(new SessionActivePage());
            
        }
    }
}