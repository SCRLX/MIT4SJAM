using System.Collections.Generic;
using Project_E.Models;
using Project_E.Pages;
using Project_E.Pages.Survey_Pages;
using Xamarin.Forms;

namespace Project_E.Navigation.Data
{
    public class MenuListData : List<Model.MenuItem>
    {
        public MenuListData()
        {
            this.Add(new Model.MenuItem()
            {
                Title = "Invullen",
                IconSource = "compose.png",
                TargetType = typeof(SurveyList)
            });
            this.Add(new Model.MenuItem()
            {
                Title = "Beheren",
                IconSource = "manage.png",
                TargetType = typeof(SurveyManage)
            });
            this.Add(new Model.MenuItem()
            {
                Title = "Instellingen",
                IconSource = "settings.png",
                TargetType = typeof(Settings)
            });
            this.Add(new Model.MenuItem()
            {
                Title = "Uitloggen",
                IconSource = "logout.png",
                TargetType = typeof(ContentPage)
            });
        }
    }
}
