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
        public NewUnitUserControl()
        {
            InitializeComponent();
            NewUnitViewModel nuvm = new NewUnitViewModel();
            DataContext = nuvm;
            //if (cuvm.CloseAction == null)
            //{
            //    var window = Window.GetWindow(this);
            //    cuvm.CloseAction = new Action(window.Close);
            //}
        }
    }
}
