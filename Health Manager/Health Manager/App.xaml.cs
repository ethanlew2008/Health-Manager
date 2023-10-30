using Health_Manager.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Health_Manager
{
    public partial class App : Application
    {

        

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainBudget());  
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            
        }

        protected override void OnResume()
        {
            
        }
    }
}
