using HelloXamarin2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarin2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPopup : ContentPage
    {
        public DetailPopup(MVAFactory.MVA selected)
        {
            InitializeComponent();
            lblTitle.Text = selected.Title;
            lblDescription.Text = selected.Description;

            Image image = new Image()
            {
                Source = "Gitpush.png"
            };

            image.GestureRecognizers.Add(
                new TapGestureRecognizer
                {
                    Command = new Command(async (t) =>
                    {
                        await image.ScaleTo(.95, 100, Easing.CubicOut);
                        await image.ScaleTo(1, 50, Easing.CubicIn);
                        await image.RotateYTo(360, 1500, Easing.SpringIn);
                    })
                });

            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(image);
            Content = stackLayout;
        }
    }
}