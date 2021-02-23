using HelloXamarin.Views.TabbedPages;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HelloXamarin.Views.CarouselPages
{
    public class CarouselPageBase : CarouselPage
    {
        public CarouselPageBase()
        {
            Children.Add(new TabbedPage1());
            Children.Add(new TabbedPage2());
        }
    }
}
