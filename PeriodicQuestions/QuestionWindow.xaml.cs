using WinUIEx;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PeriodicQuestions
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class QuestionWindow : WindowEx
    {
        public QuestionWindow()
        {
            this.InitializeComponent();
            IsTitleBarVisible = false;
            IsMinimizable = false;
            IsMaximizable = false;
            this.CenterOnScreen();
            IsAlwaysOnTop = true;
        }
    }
}
