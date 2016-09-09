using SimpleRPG.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleRPG.Commands
{
    internal class UnitUpdateCommand : ICommand
    {
        private UnitViewModel _ViewModel;

        public UnitUpdateCommand(UnitViewModel viewModel)
        {
            _ViewModel = viewModel;
        }

        #region ICommand Members

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
