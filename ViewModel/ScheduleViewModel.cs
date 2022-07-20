using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    
    internal class ScheduleViewModel : INotifyPropertyChanged
    {
       
        private List<Schedule> monday;
        private List<Schedule> tuesday;
        private List<Schedule> wednesday;
        private List<Schedule> thursday;
        private List<Schedule> friday;
        private List<Schedule> saturday;
        private List<Schedule> sunday;

        
        public ScheduleViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
    
}
