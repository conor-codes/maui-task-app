using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Task_App.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {

        public ICommand TaskCommand { get; }

        [ObservableProperty]
        ObservableCollection<string> task = new();

        public MainViewModel()
        {
            TaskCommand = new Command(TaskAdded);
        }

        public void TaskAdded() 
        {
            Task.Add("Task Added");
        }
    }
}
