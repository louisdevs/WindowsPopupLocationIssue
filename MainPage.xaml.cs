using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;
using System.Threading.Tasks;

namespace WindowsPopupLocationIssue
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var content = new ContentView()
            {
                Content = new Label() { Text = "SOME TEXT SOME TEXT SOME TEXT SOME TEXT", BackgroundColor = Colors.Red },
            };

            var popup = new Popup()
            {
                Anchor = anchor,
                Content = content,
            };

            this.ShowPopupAsync(popup);
        }
    }
}
