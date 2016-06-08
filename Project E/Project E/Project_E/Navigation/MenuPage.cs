using System.Linq;
using Project_E.Navigation.Cells;
using Xamarin.Forms;

namespace Project_E.Navigation
{
    public class MenuPage : ContentPage
    {
        public ListView Menu { get; set; }
        public Image menuImage { get; set; }
        public Label lastAddedLabel { get; set; }
        public AbsoluteLayout topMenuStackLayout { get; set; }
        public StackLayout LastAddedMovieLayout { get; set; }
        public MenuPage()
        {
            Icon = "hamburger.png";
            Title = "menu"; // The Title property must be set.
            BackgroundColor = Color.FromHex("F5F5F5");
            LastAddedMovieLayout = new StackLayout();
            Menu = new MenuListView();
             var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand

            };
            topMenuStackLayout = new AbsoluteLayout() { HeightRequest = 125 };
            //var lastAddedMovie;
            //if (lastAddedMovie != null)
            //{
                var menuLabel = new ContentView
                {
                    Padding = new Thickness(0, 0, 0, 0),
                    Content = topMenuStackLayout

                };
                //menuImage = new Image() { Source = lastAddedMovie.Poster, Aspect = Aspect.AspectFill };
                //lastAddedLabel = new Label() { Text = "Laatst toegevoegd: " + lastAddedMovie.Title, FontSize = 16, TextColor = Color.Black, FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center };
                AbsoluteLayout.SetLayoutFlags(menuImage, AbsoluteLayoutFlags.All);
                AbsoluteLayout.SetLayoutBounds(menuImage, new Rectangle(0f, 0f, 1f, 1f));
                topMenuStackLayout.Children.Add(menuImage);
                LastAddedMovieLayout.Children.Add(menuLabel);
                LastAddedMovieLayout.Children.Add(lastAddedLabel);
                layout.Children.Add(LastAddedMovieLayout);
            //}
            layout.Children.Add(Menu);

            Content = layout;
            
        }

        public void Update()
        {
            LastAddedMovieLayout.Children.Clear();
            //Movie lastAddedMovie = dbCore.GetFavorites().LastOrDefault();

            var menuLabel = new ContentView
            {
                Padding = new Thickness(0, 0, 0, 0),
                Content = topMenuStackLayout

            };
            //menuImage = new Image() { Source = lastAddedMovie.Poster, Aspect = Aspect.AspectFill };
            //lastAddedLabel = new Label() { Text = "Laatst toegevoegd: " + lastAddedMovie.Title, FontSize = 16, TextColor = Color.Black, FontAttributes = FontAttributes.Bold, HorizontalOptions = LayoutOptions.Center };
            AbsoluteLayout.SetLayoutFlags(menuImage, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(menuImage, new Rectangle(0f, 0f, 1f, 1f));
            topMenuStackLayout.Children.Add(menuImage);
            LastAddedMovieLayout.Children.Add(menuLabel);
            LastAddedMovieLayout.Children.Add(lastAddedLabel);

        }
    }
}
