using CommunityToolkit.Mvvm.ComponentModel;
using PeriodicQuestions.ActiveWindow;
using System;
using WinUIEx;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PeriodicQuestions
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    [ObservableObject]
    public sealed partial class MainWindow : WindowEx
    {

        [ObservableProperty]
        public string currentActiveWindowString;
        public MainWindow()
        {
            var watcher = new PeriodicWindowWatcher(TimeSpan.FromSeconds(10));
            this.InitializeComponent();
            watcher.ActiveWindowChanged += (o, e) => CurrentActiveWindowString = $"{e.ActiveWindow}";


        }


    }
}
