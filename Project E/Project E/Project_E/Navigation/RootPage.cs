using System;
using Xamarin.Forms;

namespace Project_E.Navigation
{
    public class RootPage : MasterDetailPage
    {
        MenuPage menuPage;

        public RootPage()
        {
            Manager.Instance.MenuPage = new MenuPage();

            menuPage = Manager.Instance.MenuPage;
            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as Model.MenuItem);
            Master = menuPage;
            Detail = new NavigationPage(new ContentPage());
        }

        public void NavigateTo(Type type)
        {
            Page page = (Page) Activator.CreateInstance(type);
            Detail = new NavigationPage(page);
        }

        public void NavigateTo(ContentPage page)
        {
            Detail = new NavigationPage(page);
        }

        public void NavigateTo(Model.MenuItem menu)
        {
            if (menu == null)
                return;
            Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);

            Detail = new NavigationPage(displayPage);

            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }
    }
}
