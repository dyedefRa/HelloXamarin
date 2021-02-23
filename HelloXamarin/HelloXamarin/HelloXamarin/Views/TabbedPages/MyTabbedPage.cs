using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HelloXamarin.Views.TabbedPages
{
    public class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            Children.Add(new TabbedPage1());
            Children.Add(new TabbedPage2());
        }
    }
}
