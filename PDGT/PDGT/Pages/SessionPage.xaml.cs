using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PDGT.Models;

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

        }
        
            private void GuideBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}