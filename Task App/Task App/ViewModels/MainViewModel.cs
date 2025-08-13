using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Task_App.Models;

namespace Task_App.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {

        public ICommand TaskCommand { get; }

        [ObservableProperty]
        ObservableCollection<TaskItem> tasks = new();

        public MainViewModel()
        {
            TaskCommand = new Command(TaskAdded);
        }

        public void TaskAdded() 
        {
            Tasks.Add(new TaskItem() { Title = "Task" , Description = "This is a task", Id = 1});
        }
    }
}
