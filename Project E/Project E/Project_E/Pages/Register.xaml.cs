using Project_E.Models;
using Project_E.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using Xamarin.Forms;

namespace Project_E.Pages
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Back_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void Register_OnClicked(object sender, EventArgs e)
        {
            User user = new User()
            {
                Email = Email_Entry.Text,
                PasswordHash = Password_Entry.Text,
                ConfirmedPassword = PasswordConfirm_Entry.Text
            };

            WebAPI api = new WebAPI();
            api.Post("account/register", JsonConvert.SerializeObject(user));

        }
    }
}
