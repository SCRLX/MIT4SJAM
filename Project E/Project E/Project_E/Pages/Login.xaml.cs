using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_E.Navigation;
using Xamarin.Forms;
using Project_E.Utilities;
using Project_E.Models;
using Project_E.Interfaces;

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

        private async void Login_OnClick(object sender, EventArgs e)
        {
            var db = DependencyService.Get<ISQLite>().GetConnection();
            WebAPI api = new WebAPI();
            User user = new User()
            {
                Email = Email_Entry.Text
            };
            var token = await api.Login(Email_Entry.Text, Password_Entry.Text);
            user.Token = token.Substring(1, 36);
            db.CreateTable<User>();
            db.Table<User>().Delete(s => s.Token != null && s.Token == null);
            db.Insert(user);
            App.RootPage = new RootPage();
            Navigation.PushModalAsync(App.RootPage);
        }
    }
}
