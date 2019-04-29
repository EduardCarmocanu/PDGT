using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PDGT.Models;

namespace PDGT.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessionPage : ContentPage
	{
        public SessionPage()
        {
            InitializeComponent();
            var images = new List<string>
           {
              "Weight.png",
              "Weight.png",
              "Weight.png"
           };


            var views = new List<string>
            {
                "1",
                "2",
                "3"
            };

            var titles = new SessionView
            {
                sicktest.SessionTitle = "Test title",
                Sets = 3,
                Reps = 10,
                WeightInKg = 5 + "kg"
            };


            CarouselViews.ItemsSource = titles.ToString();
        }


            private void GuideBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}