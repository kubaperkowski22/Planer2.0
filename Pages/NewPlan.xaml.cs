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

namespace Planer_2._0.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy NewPlan.xaml
    /// </summary>
    public partial class NewPlan : Page
    {
        public NewPlan()
        {
            InitializeComponent();

          //  this.DataContext = new Plan();
        }

        Plan Plan = new Plan();

        private void EventName_TB_LostFocus(object sender, RoutedEventArgs e)
        {
            Plan.EventName = ((TextBox)sender).Text;
        }

        private void Calendar_Box_LostFocus(object sender, RoutedEventArgs e)
        {
            Calendar_Box.SelectedDate = Plan.Date;
        }

        private void Category_CB_LostFocus(object sender, RoutedEventArgs e)
        {
            int index = Category_CB.SelectedIndex + 1;
            
            switch(index)
            {
                case 1:
                    Plan.Category = Plan.ECategory.Sport; break;
                case 2:
                    Plan.Category = Plan.ECategory.Relaks; break;
                case 3:
                    Plan.Category = Plan.ECategory.Praca; break;
                case 4:
                    Plan.Category = Plan.ECategory.Jedzenie; break;
                case 5:
                    Plan.Category = Plan.ECategory.Motoryzacja; break;
                case 6:
                    Plan.Category = Plan.ECategory.Zdrowie; break;
                case 7:
                    Plan.Category = Plan.ECategory.Gry; break;
                case 8:
                    Plan.Category = Plan.ECategory.Nauka; break;
            }
        }

        private void Priority_CB_LostFocus(object sender, RoutedEventArgs e)
        {
            Plan.Priority = Priority_CB.SelectedIndex + 1;
        }

        private void Apply_BT_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;

            NavigationService.Navigate(ClickedButton.NavUri);
        }
    }
}
