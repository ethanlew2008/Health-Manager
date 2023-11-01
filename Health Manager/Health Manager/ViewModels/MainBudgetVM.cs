using Health_Manager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;
using Health_Manager.Views;
using System.Diagnostics;

namespace Health_Manager.ViewModels
{
    public class MainBudgetVM : BindableBase
    {

        public MainBudgetVM()
        {
            YourMethod();

        }

        private readonly object lockObject = new object();
        public int Days
        {
            get { return days; }


            set
            {
                if (days != value)
                {
                    days = value;
                    OnPropertyChanged("Days");
                }
            }

        }
        private int days = 366;

        public void YourMethod()
        {
            Thread thread = new Thread(new ThreadStart(DaysThread));
            thread.Start();
        }
        private void DaysThread()
        {
            while (true)
            {
                lock (lockObject)
                {
                     //Delay Between Days
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Days -= 1;
                        MessagingCenter.Send<object, int>(this, "DaysVar", Days); //Sharing Days Count with all pages
                        if (Days == 0) { Days = 365; } //Resetting if year has passed                              
                    });
                    Thread.Sleep(5000);
                }                
            }


        }

        
   
    }
}
