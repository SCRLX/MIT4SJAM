using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Project_E.Pages
{
    public partial class SurveyAdd : ContentPage
    {
        public SurveyAdd()
        {
            InitializeComponent();
            ToolbarItems.Add(new ToolbarItem("close", "close.png", new Action(Close), ToolbarItemOrder.Default, 0));
        }

        public void Close()
        {
            Navigation.PopModalAsync();
        }
    }
}
