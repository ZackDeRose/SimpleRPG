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
            _Unit = new Models.Unit("", 0, 0, 0);
            UpdateCommand = new UnitUpdateCommand(this);
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }

        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} was updated.", Unit.Name));
        }

        
    }
}
