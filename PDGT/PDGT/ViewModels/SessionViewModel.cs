using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using PDGT.Models;
using PDGT.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDGT.ViewModels
{
   
    public class SessionViewModel
    {
        public readonly MockService _mockService = new MockService();
                
        public SessionViewModel()
        {
            _mockService.GetWeekState();

            
                                                
        }
    }
}

