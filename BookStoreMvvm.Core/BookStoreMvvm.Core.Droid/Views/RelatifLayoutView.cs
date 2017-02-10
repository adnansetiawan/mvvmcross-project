
using Acr.UserDialogs;
using Android.App;
using BookStoreMvvm.Core.ViewModel;
using MvvmCross.Droid.Views;
namespace BookStoreMvvm.UI.Droid.Views
{
    [Activity(Label = "Relatif 1", MainLauncher = true)]
    public class RelatifLayoutView : MvxActivity<RelatifLayout1ViewModel>
    {

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.RelatifLayout1);
            UserDialogs.Init(this);
        }

    }
}