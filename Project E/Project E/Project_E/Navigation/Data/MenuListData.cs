using System.Collections.Generic;
using Project_E.Pages;

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
                TargetType = typeof(Login)
            });
            this.Add(new Model.MenuItem()
            {
                Title = "Beheren",
                IconSource = "manage.png",
                TargetType = typeof(Login)
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
                TargetType = typeof(Login)
            });
        }
    }
}
