using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
