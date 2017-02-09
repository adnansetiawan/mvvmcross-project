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
    public class OtherPageViewModel : MvxViewModel
    {
        public ObservableCollection<Book> Items { get; set; }
        public OtherPageViewModel()
        {
            Items = new ObservableCollection<Book>();
            Items.Add(new Book { Id = 1, Title = "Book A", Image= "http://4.bp.blogspot.com/-0-VQUV_ZqUk/Vc4m7Lv4yVI/AAAAAAAACE8/AfOuGTumuUk/s1600/images.jpg" });
            Items.Add(new Book { Id = 2, Title = "Book B", Image = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQX78eqUDeVcnLdJpDrK1onxUk4yNdBtBeCuHh3_cC7Fos8yJ3i" });
            Items.Add(new Book { Id = 3, Title = "Book C", Image = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQ_6XZjdlCYoBIqdNEGqsaIbafFqKitM2bmzRkRimGb8XYNkkmn" });
        }
       

        public ICommand Alert
        {
            get
            {
                return new MvxCommand<Book>(b => Mvx.Resolve<IUserDialogs>().Alert($"{b.Id} - {b.Title}"));
            }
            
        }
    }
}
