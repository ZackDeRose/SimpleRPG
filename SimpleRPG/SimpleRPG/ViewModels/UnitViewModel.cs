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

        /// <summary>
        /// Gets or sets a bool value indicating whether the Unit can be updated.
        /// </summary>
        public bool CanUpdate
        {
            get
            {
                if(Unit == null)
                {
                    return false;
                }
                if (String.IsNullOrWhiteSpace(Unit.Name) || Unit.Name.Length > 10 || Unit.Name.Length < 4)
                {
                    return false;
                }
                if (!Regex.IsMatch(Unit.Name, @"^[a-zA-Z]+$"))
                {
                    return false;
                }
                if (Unit.MaxHealth < 10 || Unit.MaxHealth > 100)
                {
                    return false;
                }
                if (Unit.Attack <= 0 || Unit.Attack > 50)
                {
                    return false;
                }
                if (Unit.Defense <= 0 || Unit.MaxHealth > 50)
                {
                    return false;
                }
                return true;
            }
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
