﻿using Goldlizze.Services;
using Goldlizze.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Goldlizze
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
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
