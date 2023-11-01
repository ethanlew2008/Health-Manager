using Health_Manager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Health_Manager.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainBudget : ContentPage
    {
        int days = 0;
        public MainBudget()
        {
            InitializeComponent();
            BindingContext = new MainBudgetVM();
            MessagingCenter.Subscribe<object, int>(this, "DaysVar", (sender, arg) =>
            {
                days = arg; //Receving Days value from MainBudgetVM
            });
        }

        private void CardiologyClicked(object sender, EventArgs e)
        {          
            Navigation.PushAsync(new Cardiology(days));
        } //Navigation to respective page
    }
}