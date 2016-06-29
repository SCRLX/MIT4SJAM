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
        public SurveyListViewModel ViewModel { get; set; }
        public SurveyList()
        {

            InitializeComponent();
            ViewModel = new SurveyListViewModel();
            BindingContext = ViewModel;
        }
        public void Navigate(object sender, SelectedItemChangedEventArgs e)
        {
            App.RootPage.NavigateTo(new SurveyView(e.SelectedItem));
        }

        public void NavigateFeedback(object sender, EventArgs e)
        {
            Survey survey = ViewModel.Surveys.Where(s => s.Name == (string)((TappedEventArgs)e).Parameter).First();
            App.RootPage.NavigateTo(new FeedbackList(survey));
        }

        public void Remove(object sender, EventArgs e)
        {

        }
    }
}
