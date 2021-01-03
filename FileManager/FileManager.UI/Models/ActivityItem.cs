namespace FileManager.UI.Models
{
    public class ActivityItem : NotifyPropertyChanged
    {
        private string _image;

        public string Image
        {
            get { return _image; }
            set { _image = value; RaisePropertyChange(); }
        }

        public ActivityItem()
        {

        }
    }
}
