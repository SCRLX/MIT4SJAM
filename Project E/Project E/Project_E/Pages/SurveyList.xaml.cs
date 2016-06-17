using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project_E.Pages
{
    public partial class SurveyList : ContentPage
    {
        public SurveyList()
        {
            InitializeComponent();
        }
        public void Navigate(object sender, SelectedItemChangedEventArgs e)
        {
            App.RootPage.NavigateTo(new QuestionView(e.SelectedItem));
        }
    }
}
