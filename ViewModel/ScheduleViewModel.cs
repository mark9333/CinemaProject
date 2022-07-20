using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cinema
{
    
    internal class ScheduleViewModel : INotifyPropertyChanged
    {
        private List<Schedule> schedule;
        private List<Schedule> monday;
        private List<Schedule> tuesday;
        private List<Schedule> wednesday;
        private List<Schedule> thursday;
        private List<Schedule> friday;
        private List<Schedule> saturday;
        private List<Schedule> sunday;
        public event PropertyChangedEventHandler PropertyChanged;
        private DelegateCommand selectMondayCommand;
        private DelegateCommand selectTuesdayCommand;
        private DelegateCommand selectWednesdayCommand;
        private DelegateCommand selectThursdayCommand;
        private DelegateCommand selectFridayCommand;
        private DelegateCommand selectSaturdayCommand;
        private DelegateCommand selectSundayCommand;

        public ScheduleViewModel()
        {
            monday = new List<Schedule>();
            tuesday = new List<Schedule>();
            wednesday = new List<Schedule>();
            thursday = new List<Schedule>();
            friday = new List<Schedule>();
            saturday = new List<Schedule>();
            sunday = new List<Schedule>();

            fillSchedule();
            schedule = monday;
        }

        public List<Schedule> DayOfWeekSchedule
        {
            get
            {
                return schedule;
            }
            set
            {
                schedule = value;
                OnPropertyChanged("DayOfWeekSchedule");
            }
        }

        public ICommand SelectMondayCommand
        {
            get
            {
                return selectMondayCommand ?? (selectMondayCommand = new DelegateCommand(() =>
                {
                    DayOfWeekSchedule = monday;
                }));
            }
        }

        public ICommand SelectTuesdayCommand
        {
            get
            {
                return selectTuesdayCommand ?? (selectTuesdayCommand = new DelegateCommand(() =>
                {
                    DayOfWeekSchedule = tuesday;
                }));
            }
        }

        public ICommand SelectWednesdayCommand
        {
            get
            {
                return selectWednesdayCommand ?? (selectWednesdayCommand = new DelegateCommand(() =>
                {
                    DayOfWeekSchedule = wednesday;
                }));
            }
        }

        public ICommand SelectThursdayCommand
        {
            get
            {
                return selectThursdayCommand ?? (selectThursdayCommand = new DelegateCommand(() =>
                {
                    DayOfWeekSchedule = thursday;
                }));
            }
        }

        public ICommand SelectFridayCommand
        {
            get
            {
                return selectFridayCommand ?? (selectFridayCommand = new DelegateCommand(() =>
                {
                    DayOfWeekSchedule = friday;
                }));
            }
        }

        public ICommand SelectSaturdayCommand
        {
            get
            {
                return selectSaturdayCommand ?? (selectSaturdayCommand = new DelegateCommand(() =>
                {
                    DayOfWeekSchedule = saturday;
                }));
            }
        }

        public ICommand SelectSundayCommand
        {
            get
            {
                return selectSundayCommand ?? (selectSundayCommand = new DelegateCommand(() =>
                {
                    DayOfWeekSchedule = sunday;
                }));
            }
        }

        private void fillSchedule()
        {
            ScheduleDbContext context = new ScheduleDbContext();
            List<Schedule> movies = context.Schedule.ToList();

            foreach(var movie in movies)
            {
                if (movie.dayOfWeek.Equals("Monday"))
                {
                    monday.Add(movie);
                } else if (movie.dayOfWeek.Equals("Tuesday"))
                {
                    tuesday.Add(movie);
                } else if (movie.dayOfWeek.Equals("Wednesday"))
                {
                    wednesday.Add(movie);
                } else if (movie.dayOfWeek.Equals("Thursday"))
                {
                    thursday.Add(movie);
                } else if (movie.dayOfWeek.Equals("Friday"))
                {
                    friday.Add(movie);
                } else if (movie.dayOfWeek.Equals("Saturday"))
                {
                    saturday.Add(movie);
                }  else if (movie.dayOfWeek.Equals("Sunday"))
                {
                    sunday.Add(movie);
                } else
                {
                    throw new NullReferenceException();
                }
            }
        }

        private void OnPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
}
