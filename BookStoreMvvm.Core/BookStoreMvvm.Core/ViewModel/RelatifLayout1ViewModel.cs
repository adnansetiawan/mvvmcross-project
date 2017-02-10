using Acr.UserDialogs;
using BookStoreMvvm.Core.Extensions;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmValidation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookStoreMvvm.Core.ViewModel
{
    public class RelatifLayout1ViewModel : MvxViewModel
    {
        
        public string Title { get; set; }
        public string Author { get; set; }

        public ObservableCollection<int> Years { get; set; }
        protected ValidationHelper validator;
        public ObservableDictionary<string, string> Errors { get; set; }
        public RelatifLayout1ViewModel()
        {
            validator = new ValidationHelper();
            Years = new ObservableCollection<int>();
            Years.Add(2014);
            Years.Add(2015);
        }
        private int _selectedYear;
        public int SelectedYear
        {
            get { return _selectedYear; }
            set { _selectedYear = value;
                RaisePropertyChanged(() => SelectedYear);
                
            }
        }
       
        public ICommand Save
        {
            get
            {

                return new MvxCommand(() => ShowInfo());
                
            }

        }

        public void ShowInfo()
        {
            if (!Validate())    
            {

                //Mvx.Resolve<IUserDialogs>().ErrorToast(GetValidationError());
                return;
            }
            Mvx.Resolve<IUserDialogs>().Alert($"{this.Title}");
        }

        private string GetValidationError()
        {
            StringBuilder strBuilder = new StringBuilder();
            foreach (var error in Errors)
            {
                strBuilder.Append(error.Value);
                strBuilder.AppendLine();
            }
            return strBuilder.ToString();
        }
        private bool Validate()
        {
            //var validator = new ValidationHelper();
            //validator.AddRequiredRule(() => Title, "Title is required.");
            //validator.AddRequiredRule(() => Author, "Author is required.");
            validator.AddRule("Title", ()=> CheckTitle(Title));
            var result = validator.ValidateAll();

            Errors = result.AsObservableDictionary();
            RaisePropertyChanged(() => Errors);
            return result.IsValid;
        }

        private RuleResult CheckTitle(string Title)
        {
            RuleResult r = new RuleResult();

            if (string.IsNullOrEmpty(Title))
                r.AddError("no empty");
            else
            {
                if (Title.Length < 3)
                    r.AddError("minimum char 3");

            }
            return r;
        }
    }
}
