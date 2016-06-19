using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Models;
using Project_E.ViewModels;
using Xamarin.Forms;

namespace Project_E.Pages
{
    public partial class SurveyList : ContentPage
    {
        public SurveyList()
        {
            InitializeComponent();
            BindingContext = new SurveyListViewModel();
        }
        public void Navigate(object sender, SelectedItemChangedEventArgs e)
        {
            App.RootPage.NavigateTo(new SurveyView(e.SelectedItem));
        }
    }
}
