﻿using System;
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
            set {
                _newUnitViewModel = value;
                _newUnitViewModel.CancelAction = CancelAction;
                _newUnitViewModel.CreateUnitAction = CreateUnitAction;
                OnPropertyChanged("NewUnitViewModel");
            }
        }

        private Action _createUnitAction;
        public Action CreateUnitAction
        {
            get
            {
                return _createUnitAction;
            }
            set
            {
                _createUnitAction = value;
                if (NewUnitViewModel != null)
                {
                    NewUnitViewModel.CreateUnitAction = value;
                }
                OnPropertyChanged("CreateUnitAction");
            }
        }

        private Action _cancelAction;
        public Action CancelAction
        {
            get
            {
                return _cancelAction;
            }
            set
            {
                _cancelAction = value;
                if (NewUnitViewModel != null)
                {
                    _newUnitViewModel.CancelAction = this.CancelAction;
                }
                OnPropertyChanged("CreateUnitAction");
            }
        }

        public NewUnitDialogViewModel()
        {
            CreateUnitAction = CreateUnit;
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
