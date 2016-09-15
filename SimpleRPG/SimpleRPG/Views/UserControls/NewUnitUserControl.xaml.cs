using SimpleRPG.Models;
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
        #region DependencyProperties

        /// <summary>
        /// Gets or sets the Value which is being displayed
        /// </summary>
        public object ViewModel
        {
            get { return GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty ViewModelProperty =
            DependencyProperty.Register("ViewModel", typeof(NewUnitViewModel),
              typeof(NewUnitUserControl), new PropertyMetadata(null));


        public object Unit
        {
            get { return GetValue(UnitProperty); }
            set { SetValue(UnitProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty UnitProperty =
            DependencyProperty.Register("Unit", typeof(Unit),
              typeof(NewUnitUserControl), new PropertyMetadata(null));

        public object CancelCommand
        {
            get { return GetValue(CancelCommandProperty); }
            set { SetValue(CancelCommandProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty CancelCommandProperty =
            DependencyProperty.Register("CancelCommand", typeof(object),
              typeof(NewUnitUserControl), new PropertyMetadata(null));

        public object CreateCommand
        {
            get { return GetValue(CreateCommandProperty); }
            set { SetValue(CreateCommandProperty, value); }
        }

        /// <summary>
        /// Identified the Label dependency property
        /// </summary>
        public static readonly DependencyProperty CreateCommandProperty =
            DependencyProperty.Register("CreateCommand", typeof(object),
              typeof(NewUnitUserControl), new PropertyMetadata(null));


        #endregion

        public NewUnitUserControl()
        {
            InitializeComponent();
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
