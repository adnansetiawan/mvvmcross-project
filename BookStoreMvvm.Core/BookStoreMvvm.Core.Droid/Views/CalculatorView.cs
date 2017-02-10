
using Android.App;
using BookStoreMvvm.Core.ViewModel;
using MvvmCross.Droid.Views;

namespace BookStoreMvvm.UI.Droid.Views
{
    //[Activity(Label = "Calculator", MainLauncher = true)]
    public class CalculatorView : MvxActivity<CalculatorViewModel>
    {
       
       
        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.Calculator);
            
        }

        
    }
}