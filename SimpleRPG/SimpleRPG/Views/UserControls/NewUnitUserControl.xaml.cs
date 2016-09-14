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
        #region Value DP

        /// <summary>
        /// Gets or sets the Value which is being displayed
        /// </summary>
        public object Value
        {
            get { return (object)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(object),
              typeof(NewUnitUserControl), new PropertyMetadata(null));

        #endregion

        public NewUnitUserControl()
        {
            InitializeComponent();
            NewUnitViewModel nuvm = new NewUnitViewModel();
            LayoutRoot.DataContext = this;
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
