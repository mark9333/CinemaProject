﻿using System;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GridViewColumn_Opened(object sender, RoutedEventArgs e)
        {

        }

        private void btnMonday_Click(object sender, RoutedEventArgs e)
        {
            Test.Visibility = Visibility.Collapsed; 
        }
    }
}
