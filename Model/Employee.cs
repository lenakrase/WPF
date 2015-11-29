using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Model.Annotations;

namespace Model
{
    public class Employee :INotifyPropertyChanged
    {
        private bool _isDeleted;
        private DateTime _fireDate;
        public string Name { get; set; }
        public DateTime HireDate { get; set; }

        public DateTime FireDate
        {
            get { return _fireDate; }
            set
            {
                _fireDate = value;
                OnPropertyChanged();
            }
        }

        public bool IsDeleted
        {
            get { return _isDeleted; }
            set
            {
                _isDeleted = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
