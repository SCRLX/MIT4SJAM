using System;
using Project_E.Pages;
using Xamarin.Forms;
using Project_E.ViewModels;

namespace Project_E.Navigation
{
    public class RootPage : MasterDetailPage
    {
        MenuPage menuPage;
        public RootPage()
        {
            Manager.Instance.MenuPage = new MenuPage();
            ToolbarItems.Add(new ToolbarItem("Add","add.png", new Action(Add)));
            menuPage = Manager.Instance.MenuPage;
            Master = menuPage;
            Detail = new NavigationPage(new SurveyList());
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

            IsPresented = false;
        }

        public void NavigateTo(CarouselPage page)
        {
            Detail = new NavigationPage(page);
        }
        private void Add()
        {
            Navigation.PushModalAsync(new NavigationPage(new SurveyAdd()),true);
        }
    }
}
