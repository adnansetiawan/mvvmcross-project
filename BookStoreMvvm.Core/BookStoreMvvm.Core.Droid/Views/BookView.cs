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
    //[Activity(Label = "Book List", MainLauncher = true)]
    [Activity(Label = "Book List")]
    public class BookView : MvxActivity<BookViewModel>
    {
        
        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.BookListView);
            UserDialogs.Init(this);
        }
        
    }
}