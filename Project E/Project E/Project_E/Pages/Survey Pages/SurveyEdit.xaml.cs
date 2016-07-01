using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Models;
using Project_E.Pages.Survey_Pages;
using Xamarin.Forms;

namespace Project_E.Pages
{
    public partial class SurveyEdit : ContentPage
    {
        public static Survey Survey { get; set; }
        public SurveyEdit(object survey)
        {
            Survey = (Survey) survey;
            InitializeComponent();
            BindingContext = Survey;
        }
        public void Remove(object sender, EventArgs e)
        {

        }

        private void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Navigation.PushModalAsync(new NavigationPage(new QuestionEdit((Question)e.SelectedItem)));
                ((ListView)sender).SelectedItem = null;
            }
            else
            {
                return;
            }

        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            
        }
    }
}
