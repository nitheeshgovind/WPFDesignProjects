using FileManager.UI.Models;
using System.Collections.ObjectModel;

namespace FileManager.UI.Controls.Design
{
    public class ActivityDesignModel : ActivityModel
    {
        public static ActivityDesignModel Instance => new ActivityDesignModel();

        public ActivityDesignModel()
        {
            ActivityTime = "1 Minute Ago";
            Type = ActivityType.Image;
            Source = "Google";
            Items = new ObservableCollection<ActivityItem>()
                {
                    new ActivityItem(){ Image = "image"},
                    new ActivityItem(){ Image = "image"},
                    new ActivityItem(){ Image = "desk2"},
                    new ActivityItem() { Image = "desk2"}
                };
        }
    }
}
