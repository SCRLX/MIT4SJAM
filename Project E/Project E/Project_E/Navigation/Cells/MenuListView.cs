using System.Collections.Generic;
using Project_E.Navigation.Data;

using Xamarin.Forms;

namespace Project_E.Navigation.Cells
{
    public class MenuListView : ListView
    {
        public MenuListView()
        {
            List<Model.MenuItem> data = new MenuListData();

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;
            SeparatorColor = Color.White;

            var cell = new DataTemplate(typeof(ImageCell));
            cell.SetBinding(TextCell.TextProperty, "Title");
            cell.SetValue(TextCell.TextColorProperty, Color.FromHex("#FFF"));
            cell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
            ItemTemplate = cell;
        }
    }
}
