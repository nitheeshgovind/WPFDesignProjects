namespace FileManager.UI.ViewModels
{
    public class MainViewModel : NotifyPropertyChanged
    {
        public ActivityViewModel ActivityViewModel { get; set; }

        public MainViewModel()
        {
            ActivityViewModel = new ActivityViewModel();
        }
    }
}
