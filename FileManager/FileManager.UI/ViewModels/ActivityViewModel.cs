using FileManager.UI.Models;
using System.Collections.ObjectModel;

namespace FileManager.UI.ViewModels
{
    public class ActivityViewModel : NotifyPropertyChanged
    {
        public ObservableCollection<ActivityModel> Activities { get; set; }

        public ActivityViewModel()
        {
            LoadActivities();
        }

        private void LoadActivities()
        {
            //

            Activities = new ObservableCollection<ActivityModel>();

            Activities.Add(new ActivityModel()
            {
                ActivityTime = "1 Minute Ago",
                Type = ActivityType.Image,
                Source = "Google",
                Items = new ObservableCollection<ActivityItem>()
                {
                    new ActivityItem(){ Image = "desk"},
                    new ActivityItem(){ Image = "desk"},
                    new ActivityItem(){ Image = "desk2"},
                    new ActivityItem() { Image = "desk2"}
                }
            });


            RaisePropertyChange(nameof(Activities));
        }
    }
}
