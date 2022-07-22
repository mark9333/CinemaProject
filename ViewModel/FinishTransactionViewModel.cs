using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class FinishTransactionViewModel
    {
        private List<int> chosenPlaces;
        private User user;
        private Schedule movie;
        private DelegateCommand continueCommand;

        public FinishTransactionViewModel(List<int> chosenPlaces, User user, Schedule movie)
        {
            this.chosenPlaces = chosenPlaces;
            this.user = user;
            this.movie = movie;
        }

        public DelegateCommand FinishCommand
        {
            get
            {
                return continueCommand ?? (continueCommand = new DelegateCommand(() =>
                {
                    PlaceDbContext placeDbContext = new PlaceDbContext();
                    OrderDbContext orderDbContext = new OrderDbContext();
                    Order order = new Order();
                    order.projection_id = movie.id;
                    order.user_id = user.id;

                    orderDbContext.Orders.Add(order);

                    foreach (var placeNumber in chosenPlaces)
                    {
                        Place place = new Place();
                        place.place = placeNumber;
                        place.projection_id = movie.id;

                        placeDbContext.Places.Add(place);
                    }

                    orderDbContext.SaveChanges();
                    placeDbContext.SaveChanges();
                }));
            }
        }

        public String MovieName
        {
            get
            {
                return movie.movie_name;
            }
  
        }

        public decimal Price
        {
            get
            {
                return movie.price * chosenPlaces.Count;
            }
        }

        public String Day
        {
            get
            {
                return movie.day_of_projection;
            }
        }

        public String Time
        {
            get
            {
                return movie.time_of_projection;
            }
        }

        public String Places
        {
            get
            {
                StringBuilder places = new StringBuilder();

                foreach (var place in chosenPlaces)
                {
                    places.Append(place + " | ");
                }

                return places.ToString();
            }
        }
    }
}
