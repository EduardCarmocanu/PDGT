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

            CarouselViews.ItemsSource = views;
        }


            private void GuideBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}