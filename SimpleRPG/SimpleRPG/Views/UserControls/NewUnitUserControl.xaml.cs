using SimpleRPG.ViewModels;
using SimpleRPG.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleRPG.Views.UserControls
{
    /// <summary>
    /// Interaction logic for NewUnitUserControl.xaml
    /// </summary>
    public partial class NewUnitUserControl : UserControl
    {
        private Window _parentWindow = null;
        public NewUnitUserControl()
        {
            InitializeComponent();
            NewUnitViewModel nuvm = new NewUnitViewModel();
            DataContext = nuvm;
            //Loaded += (s, e) =>
            //{
            //    _parentWindow = Window.GetWindow(this);
            //    if (nuvm.CloseAction == null)
            //    {
            //        nuvm.CloseAction = new Action(_parentWindow.Close);
            //    }
            //};
        }
    }
}
