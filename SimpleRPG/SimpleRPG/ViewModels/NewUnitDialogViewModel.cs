using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG.ViewModels
{
    class NewUnitDialogViewModel : INotifyPropertyChanged
    {
        private NewUnitViewModel _newUnitViewModel;
        public NewUnitViewModel NewUnitViewModel {
            get { return _newUnitViewModel; }
            set { _newUnitViewModel = value; OnPropertyChanged("NewUnitViewModel"); }
        }

        public Action CreateUnitAction { get; set; }
        public Action CancelAction { get; set; }

        public NewUnitDialogViewModel(NewUnitViewModel nuvm)
        {
            NewUnitViewModel = nuvm;
            NewUnitViewModel.Enabled = true;
            CreateUnitAction = CreateUnit;
            NewUnitViewModel.CreateUnitAction = this.CreateUnitAction;
            NewUnitViewModel.CancelAction = this.CancelAction;
        }

        public void CreateUnit()
        {
            Debug.Assert(false, String.Format("{0} was created", NewUnitViewModel.Unit.Name));
        }

        public void Cancel()
        {
            this.CancelAction();
        }

        #region INotifyProperty Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
