using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HelloXamarin.Views
{
    public class MyContentPageWithClass : ContentPage
    {

        public MyContentPageWithClass()
        {
            Label lblPage = new Label();
            lblPage.Text = "Merhaba Xamarin :)";
            lblPage.FontSize = 30;
            lblPage.HorizontalOptions = LayoutOptions.Center;
            lblPage.VerticalOptions = LayoutOptions.Center;

            //*** Class ile yaptık .
            Content = lblPage;
        }
    }
}
