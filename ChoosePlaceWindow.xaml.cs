using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Cinema
{
    
    public partial class ChoosePlace : Window
    {
        private PlaceDbContext context;
        private List<int> chosenPlaces;
        private Schedule movie;
        private User user;

        public ChoosePlace(Schedule movie, User user)
        {
            InitializeComponent();
            this.movie = movie;
            this.user = user;
            context = new PlaceDbContext();
            showFreePlaces();
        }

        private void showFreePlaces()
        {
            List<Place> places = context.Places.ToList();
            List<int> placeNumbers = (from p in places where p.projection_id == movie.id select p.place).ToList();

            foreach (var item in ChoosePlaceGrid.Children)
            {  

                if (item is Button)
                {
                    Button btn = (Button)item;

                    if (placeNumbers.Contains(Int32.Parse(btn.Content.ToString())))
                    {
                        btn.IsEnabled = false;
                    }
                    
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
            this.Close();
        }

        private void continueClick(object sender, RoutedEventArgs e)
        {
            chosenPlaces = new List<int>();
            foreach (var item in ChoosePlaceGrid.Children)
            { 
                if (item is Button)
                {
                    Button btn = (Button)item;
                    
                    if (btn.Background == Brushes.Red)
                    {
                        chosenPlaces.Add(Int32.Parse(btn.Content.ToString()));
                    }
                }
            }

            Window finishTransactionWindow = new FinishTransactionWindow(chosenPlaces, user, movie);
            finishTransactionWindow.ShowDialog();
            this.Close();
        }
    }
}





