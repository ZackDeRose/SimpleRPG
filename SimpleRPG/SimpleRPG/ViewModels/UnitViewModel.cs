using SimpleRPG.Commands;
using SimpleRPG.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleRPG.ViewModels
{
    internal class UnitViewModel
    {
        private Unit _Unit;
        public Unit Unit
        {
            get
            {
                return _Unit;
            }
        }

        /// <summary>
        /// Initializes an instance of the UnitViewModel class
        /// </summary>
        public UnitViewModel()
        {
            _Unit = new Models.Unit("", 0, 0, 0, 0);
        }

        public UnitViewModel(Unit unit)
        {
            _Unit = unit;
        }

        public void DoStuff()
        {
            List<Unit> myStuff = new List<Unit>();
            List<Unit> unitsa = myStuff.FindAll(t => t.Defense > 50);

            List<Unit> units = (from temp in myStuff where temp.Defense > 50 select temp).ToList();
        }


        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} was updated.", Unit.Name));
        }


        private ICommand _unitUpdateCommand;
        public ICommand UnitUpdateCommand
        {
            get
            {
                if (_unitUpdateCommand == null)
                    _unitUpdateCommand = new RelayCommand(
                        param => SaveChanges(),
                        param => string.IsNullOrWhiteSpace(Unit.ClassError));

                return _unitUpdateCommand;
            }
        }

    }
}
