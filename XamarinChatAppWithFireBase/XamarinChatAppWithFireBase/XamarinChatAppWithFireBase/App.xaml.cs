﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinChatAppWithFireBase.Views;

namespace XamarinChatAppWithFireBase
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RoomPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
