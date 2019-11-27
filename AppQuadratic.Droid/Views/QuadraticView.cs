
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppQuadratic.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace AppQuadratic.Droid.Views
{
    [Activity(Label = "@string/app_name")]
    public class QuadraticView : MvxActivity<QuadraticViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.QuadraticPage);
        }
    }
}
