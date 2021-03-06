﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unzone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

#if DEBUG
            //EnableDebugRainbows(true);
#endif

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        /// <summary>
        /// 開啟 DebugRainbows必須要加入的方法
        /// </summary>
        /// <param name="shouldUseDebugRainbows"></param>
        void EnableDebugRainbows(bool shouldUseDebugRainbows)
        {
            Resources.Add(new Style(typeof(ContentPage))
            {
                ApplyToDerivedTypes = true,
                Setters = {
                new Setter
                {
                    Property = Xamarin.Forms.DebugRainbows.DebugRainbow.IsDebugProperty,
                    Value = shouldUseDebugRainbows
                }
            }
            });
        }
    }
}
