using SimpleRPG.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public UnitViewModel()
        {
            _Unit = new Models.Unit("Paladin Maccabeus", 30, 7, 5);
            UpdateCommand = new UnitUpdateCommand();
        }

        public ICommand UpdateCommand
        {

        }

        public void SaveChanges()
        {
            Debug.Assert(false, String.Format("{0} was updated.", Unit.Name));
        }
    }
}
