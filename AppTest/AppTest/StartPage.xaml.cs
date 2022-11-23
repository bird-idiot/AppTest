using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            Label label = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                Text = ""
            };
            Button btn = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                Text = "Click on the button"
            };
            
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children = {btn, label}
            };

            btn.Clicked += delegate
            {
                if (label.Text == "Hello world!") 
                    label.Text = "See you again!";
                else 
                    label.Text = "Hello world!";
            };

        }

    }
}