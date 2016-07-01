using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.ViewModels;
using Xamarin.Forms;

namespace Project_E.Pages.Survey_Pages
{
    public partial class SurveyManage : ContentPage
    {
        public SurveyManage()
        {
            InitializeComponent();
            BindingContext = new SurveyListViewModel();
        }
        public void Navigate(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                App.RootPage.NavigateTo(new SurveyEdit(e.SelectedItem));
                ((ListView)sender).SelectedItem = null;
            }
            else
            {
                return;
            }

        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            
        }
    }
}
