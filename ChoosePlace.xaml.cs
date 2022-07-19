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

namespace Cinema
{
    
    public partial class ChoosePlace : Window
    {
        public ChoosePlace()
        {
            InitializeComponent();
            

        }

        private void showFreePlaces()
        {
            foreach (var item in ChoosePlaceGrid.Children)
            {

                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.Background = Brushes.Green;
                }
            }
        }

        private void choosePlace(object sender, RoutedEventArgs e)
        {
            Button btn = ((Button)sender);
            

            if (btn.Background == Brushes.Green)
            {
                btn.Background = Brushes.Red;
            }
            else
                btn.Background = Brushes.Green;
        }

        private void backClick(object sender, RoutedEventArgs e)
        {
            var ProgramPage = new MainWindow(); 
            ProgramPage.Show(); 
            this.Close();
        }
        private void continueClick(object sender, RoutedEventArgs e)
        {
            //var ProgramPage = new MainWindow();
           // ProgramPage.Show();
            //this.Close();
        }

    }
}





