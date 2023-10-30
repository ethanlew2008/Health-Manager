using Health_Manager.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;
using Health_Manager.Views;

namespace Health_Manager.ViewModels
{
    public class CardiologyVM: BindableBase
    {
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
        private int days;

        public int Staff
        {
            get { return staff; }


            set
            {
                if (staff != value)
                {
                    staff = value;
                    OnPropertyChanged("Staff");
                }
            }

        }
        private int staff;

        

        public CardiologyVM()
        {
            MessagingCenter.Subscribe<object, int>(this, "DaysVar", (sender, arg) =>
            {
                Days = arg; //Receving Days value from MainBudgetVM
            });          
            
        }
        
        private void StaffClicked()
        {

        }

    }
}
