using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookStoreMvvm.Core
{
    public class Book 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }

      

    }
}
