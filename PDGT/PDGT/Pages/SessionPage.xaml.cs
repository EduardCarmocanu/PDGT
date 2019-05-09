using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PDGT.ViewModels;

namespace PDGT.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessionPage : ContentPage
	{
        SessionViewModel _vm;
        
        public SessionPage()
        {
            InitializeComponent();

            BindingContext = _vm = new SessionViewModel();

            //Array with name of weekdays
            var weekDays = new List<string>
            {
                "mon",
                "tue",
                "wed",
                "thu",
                "fri",
                "sat",
                "sun"
            };
            
        }

        
               
        private async void GuideBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Viewguide());
        }

        private void StartSessionBtn(object sender, EventArgs e)
        {
            //Code for navigating to the "Training" Tabnav
        }
    }
}