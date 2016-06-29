using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Models;
using Project_E.Navigation.Model;
using Project_E.Pages;
using Project_E.ViewModels;
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

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                if (((Model.MenuItem) e.SelectedItem).Title == "Uitloggen")
                {
                    App.RootPage.Navigation.PopModalAsync(true);
                    return;
                }
                App.RootPage.NavigateTo((Model.MenuItem) e.SelectedItem);
                ((ListView) sender).SelectedItem = null;
            }
            else
            {
                return;
            }
        }
    }
}
