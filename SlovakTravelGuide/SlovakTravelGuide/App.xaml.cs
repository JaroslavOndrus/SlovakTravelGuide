﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlovakTravelGuide
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartMenu());
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
