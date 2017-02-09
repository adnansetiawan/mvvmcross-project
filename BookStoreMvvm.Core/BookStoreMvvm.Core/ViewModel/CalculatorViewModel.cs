using BookStoreMvvm.Core.Services.Contracts;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BookStoreMvvm.Core.ViewModel
{
    public class CalculatorViewModel : MvxViewModel
    {
        IMvxCommand _showOtherPage;
        ICalculatorService _calculatorService;
        public CalculatorViewModel(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
            _showOtherPage = new MvxCommand(() => ShowOtherPage());
        }
        public override void Start()
        {
            Add();
            base.Start();
        }

        int _operand1;
        public int Operand1
        {
            get { return _operand1; }
            set
            {
                _operand1 = value;
                Add();

            }
        }

        int _operand2;
        public int Operand2
        {
            get { return _operand2; }
            set
            {
                _operand2 = value;
                Add();

            }
        }
        int _result;
        public int Result
        {
            get { return _result; }
            set {
                _result = value;
                RaisePropertyChanged(() => Result);
            }
        }

        private void Add()
        {
            Result = _calculatorService.Add(_operand1, _operand2);
        }

        public ICommand Navigate
        {
            get
            {
                return _showOtherPage;
            }
        }
        protected void ShowOtherPage()
        {
            ShowViewModel<OtherPageViewModel>();
        }
    }
}
