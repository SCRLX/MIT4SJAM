using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Navigation;
using Xamarin.Forms;

namespace Project_E.Pages
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Register_OnClick(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Register());
        }

        private void Login_OnClick(object sender, EventArgs e)
        {
            App.RootPage = new RootPage();
            Navigation.PushModalAsync(App.RootPage);
        }
    }
}
