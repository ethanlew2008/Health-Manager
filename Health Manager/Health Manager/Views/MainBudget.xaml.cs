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
        public MainBudget()
        {
            InitializeComponent();
            BindingContext = new MainBudgetVM(); 
        }

        private void CardiologyClicked(object sender, EventArgs e)
        {          
            Navigation.PushAsync(new Cardiology());
        } //Navigation to respective page
    }
}