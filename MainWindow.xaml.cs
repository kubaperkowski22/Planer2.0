using Planer_2._0.ViewModels;
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

namespace Planer_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        MainWindowVM ViewModel = new MainWindowVM();
        

        private void Start_BT_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Visibility = Visibility.Visible;

            Welcome_SP.Visibility = Visibility.Hidden;
        }

        private void Close_BT_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Close_BT_Click();
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
