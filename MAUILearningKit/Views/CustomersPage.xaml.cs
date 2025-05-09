
using MAUILearningKit.ViewModels;
using MAUILearningKit.Models;

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

        private async void OnCustomerSelected(object? sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Customer selectedCustomer)
            {
                await Shell.Current.GoToAsync(nameof(OrdersPage), 
                    new Dictionary<string, object>
                    {
                        { "SelectedCustomer", selectedCustomer }
                    });
            }
        }
        private async void OnAddCustomerClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AddCustomerPage));
        }
    
    }
}