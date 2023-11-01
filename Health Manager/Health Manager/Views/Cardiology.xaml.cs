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
    public partial class Cardiology : ContentPage
    {
        public Cardiology(int days)
        {
            InitializeComponent();
            BindingContext = new CardiologyVM(days);
            if(App.Current.RequestedTheme == OSAppTheme.Dark) { BackgroundColor = Color.Black; } //Setting of Theme is here due to delay in Xaml
            else { BackgroundColor = Color.White; }

           

        }
    }
}