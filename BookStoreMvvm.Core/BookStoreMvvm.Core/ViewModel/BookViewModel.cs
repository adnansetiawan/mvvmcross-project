using Acr.UserDialogs;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookStoreMvvm.Core.ViewModel
{
    public class BookViewModel : MvxViewModel
    {
        public ObservableCollection<Book> Items { get; set; }
        public BookViewModel()
        {
            Items = new ObservableCollection<Book>();
            Items.Add(
                new Book
                {
                    Id = 1,
                    Title = "Lord Of The Ring",
                    Author = "JJR. TOLKIEN",
                    Price = 40,
                    Year = 2001,
                    Image = "https://luckty.files.wordpress.com/2012/05/b32.jpg"
                });
            Items.Add(
                new Book
                {
                    Id = 2,
                    Title = "The Hobbit",
                    Author = "JJR. TOLKIEN",
                    Price = 35,
                    Year = 2014,
                    Image = "https://images-na.ssl-images-amazon.com/images/I/41aQPTCmeVL._SX331_BO1,204,203,200_.jpg"
                });

        }
       

        public ICommand ShowInfo
        {
            get
            {
                return new MvxCommand<Book>(b => Mvx.Resolve<IUserDialogs>().Alert(GetInfo(b)));
            }
            
        }

        protected string GetInfo(Book book)
        {
            var output = new StringBuilder();
            output.Append($"Author: {book.Author}");
            output.AppendLine();
            output.Append($"Year: {book.Year}");
            output.AppendLine();
            output.Append($"Price: {book.Price}");
            return output.ToString();
        }
    }
}
