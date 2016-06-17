using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Navigation.Model;
using Xamarin.Forms;

namespace Project_E.Navigation
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            BindingContext = new MenuViewModel();
        }

        public void Navigate(object sender, SelectedItemChangedEventArgs e)
        {
            App.RootPage.NavigateTo((Model.MenuItem)e.SelectedItem);
        }
    }
}
