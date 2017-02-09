using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using BookStoreMvvm.Core.ViewModel;
using Acr.UserDialogs;

namespace BookStoreMvvm.UI.Droid.Views
{
    [Activity(Label = "Other Page")]
    public class OtherPageView : MvxActivity<BookViewModel>
    {
        
        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.BookInListView);
            UserDialogs.Init(this);
        }


    }
}