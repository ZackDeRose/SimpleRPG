using SimpleRPG.ViewModels;
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
using System.Windows.Shapes;

namespace SimpleRPG.Views
{
    /// <summary>
    /// Interaction logic for NewUnitWindow.xaml
    /// </summary>
    public partial class NewUnitWindow : Window
    {
        System.Drawing.Point windowLoc = Properties.Settings.Default.WindowsLoc;
        System.Drawing.Size windowSize = Properties.Settings.Default.WindowSize;

        public NewUnitWindow()
        {
            InitializeComponent();
            SetWindowProperties();
            //CreateUnitViewModel cuvm = new CreateUnitViewModel();
            //DataContext = cuvm;
            //if(cuvm.CloseAction == null)
            //{
            //    cuvm.CloseAction = new Action(this.Close);
            //}
        }

        private void SetWindowProperties()
        {
            this.Top = windowLoc.Y;
            this.Left = windowLoc.X;
        }


        private void SaveProperties()
        {

            System.Drawing.Point tempPoint = new System.Drawing.Point((int)this.Left, (int)this.Top);

            Properties.Settings.Default.WindowsLoc= tempPoint;

            Properties.Settings.Default.Save();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveProperties();
        }
    }
}
