using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace FileManager.UI.Models
{
    public class ActivityModel : NotifyPropertyChanged
    {
        private ObservableCollection<ActivityItem> _items;

        public ObservableCollection<ActivityItem> Items
        {
            get { return _items; }
            set { _items = value; RaisePropertyChange(); }
        }

        public IEnumerable<ActivityItem> DisplayItems
        {
            get
            {
                return Items == null ? null : Items.Take(3);
            }
        }

        public ActivityType Type { get; set; }

        public string ActivityTime { get; set; }

        public string Source { get; set; }

        public bool IsVideo
        {
            get { return Type == ActivityType.Video; }
        }

        public int Count { get { return Items == null ? 0 : Items.Count; } }
    }
}
