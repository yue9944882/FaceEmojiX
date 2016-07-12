using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms;

namespace FaceEmojiX.Droid
{
    [Activity(Label = "FaceEmojiX", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            App app = new App();

            LoadApplication(app);

            MessagingCenter.Subscribe<EntryPage, NativeNavigationArgs>(
                this,
                App.NativeNavigationMessage,
                HandleNativeNavigationMessage
                );

        }

        private void HandleNativeNavigationMessage(EntryPage sender, NativeNavigationArgs args)
        {
            StartActivity(typeof(TakePhotoActivity));
        }
    }
}

