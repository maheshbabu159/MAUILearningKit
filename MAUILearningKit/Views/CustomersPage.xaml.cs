
using MAUILearningKit.ViewModels;

namespace MAUILearningKit.Views
{
    public partial class CustomersPage : ContentPage
    {
        private CustomersViewModel ViewModel => (BindingContext as CustomersViewModel)!;
        public CustomersPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.LoadCustomersCommand.ExecuteAsync(null);
        }
    }
}