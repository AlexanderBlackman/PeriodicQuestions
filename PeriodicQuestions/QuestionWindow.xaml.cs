using System;
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
            this.Maximize();
            this.CenterOnScreen();
            //   IsAlwaysOnTop = true;
        }
        // public bool  CanSubmit { get; set; } = (whyTB.Text 
        public bool CanSubmit(object? parameter) => whyTB.Text is not null;

        private void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void whyTB_TextChanged(object sender, Microsoft.UI.Xaml.Controls.TextChangedEventArgs e)
        {
            submitButton.IsEnabled = (whyTB.Text != String.Empty);
        }
    }
}
