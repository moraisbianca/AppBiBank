﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AppBancoDigital;
using Plugin.Fingerprint;

namespace AppBancoDigital.Droid
{
    [Activity(Label = "AppBancoDigital", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            CrossFingerprint.SetCurrentActivityResolver(() => Xamarin.Essentials.Platform.CurrentActivity);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Rg.Plugins.Popup.Popup.Init(this);
            LoadApplication(new App());

            Window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);
            Window.AddFlags(Android.Views.WindowManagerFlags.LayoutNoLimits);
            Window.AddFlags(Android.Views.WindowManagerFlags.LayoutInScreen);
            Window.DecorView.SetFitsSystemWindows(true);
    }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}