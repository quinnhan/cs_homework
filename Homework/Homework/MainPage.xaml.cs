using Homework.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Homework
{
    public sealed partial class MainPage : Page
    {
        public MainPageVM ViewModel { get; private set; }

        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.ViewModel = new MainPageVM();
            this.DataContext = this.ViewModel;
        }
    }
}
