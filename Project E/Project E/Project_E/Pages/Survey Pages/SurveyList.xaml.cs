using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Models;
using Project_E.ViewModels;
using Xamarin.Forms;
using Project_E.Utilities;

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
            WebAPI api = new WebAPI();
            string list = api.Get("survey/getlist"); //lijst van mogelijke surveys ophalen
            int a = 0;
        }
        public void Navigate(object sender, SelectedItemChangedEventArgs e)
        {
            App.RootPage.NavigateTo(new SurveyView(e.SelectedItem));
        }

        public void NavigateFeedback(object sender, EventArgs e)
        {
            Survey survey = ViewModel.Surveys.Where(s => s.SurveyName == (string)((TappedEventArgs)e).Parameter).First();
            App.RootPage.NavigateTo(new FeedbackList(survey));
        }

        public void Remove(object sender, EventArgs e)
        {

        }
    }
}
