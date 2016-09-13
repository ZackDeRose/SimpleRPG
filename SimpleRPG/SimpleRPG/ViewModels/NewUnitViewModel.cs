using SimpleRPG.Commands;
using SimpleRPG.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleRPG.ViewModels
{
    internal class NewUnitViewModel : INotifyPropertyChanged
    {
        #region Properties

        private Unit _unit;
        public Unit Unit
        {
            get { return _unit; }
            set { _unit = value; OnPropertyChanged("Unit"); }
        }

        public Action CloseAction { get; set; }

        private ICommand _createUnitCommand;
        public ICommand CreateUnitCommand
        {
            get
            {
                if (_createUnitCommand == null)
                {
                    _createUnitCommand = new RelayCommand(param => CreateUnit(), 
                        param => string.IsNullOrWhiteSpace(Unit.ClassError));
                }
                return _createUnitCommand;
            }
        }

        private ICommand _cancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                if (_cancelCommand == null)
                {
                    _cancelCommand = new RelayCommand(param => Cancel(), param => true);
                }
                return _cancelCommand;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes an instance of the UnitViewModel class
        /// </summary>
        public NewUnitViewModel()
        {
            _unit = new Models.Unit("", 0, 0, 0, 0);
        }

        public NewUnitViewModel(Unit unit)
        {
            _unit = unit;
        }

        public NewUnitViewModel(String name, int health, int speed, int attack, int defense)
        {
            _unit = new Models.Unit(name, health, speed, attack, defense);
        }

        #endregion

        #region Methods

        //public void DoStuff()
        //{
        //    List<Unit> myStuff = new List<Unit>();
        //    List<Unit> unitsa = myStuff.FindAll(t => t.Defense > 50);

        //    List<Unit> units = (from temp in myStuff where temp.Defense > 50 select temp).ToList();
        //}

        public void CreateUnit()
        {
            Debug.Assert(false, String.Format("{0} was created.", Unit.Name));
        }

        public void Cancel()
        {
            this.CloseAction();
        }

        #endregion

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
