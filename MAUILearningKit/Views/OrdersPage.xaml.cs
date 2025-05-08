
using MAUILearningKit.ViewModels;
using MAUILearningKit.Models;

namespace MAUILearningKit.Views
{
    [QueryProperty(nameof(SelectedCustomer), "SelectedCustomer")]
    public partial class OrdersPage : ContentPage
    {
         private Customer? _selectedCustomer;

        public Customer SelectedCustomer
        {
            get => _selectedCustomer!;
            set
            {
                _selectedCustomer = value;
            }
        }
        private OrdersViewModel ViewModel => (BindingContext as OrdersViewModel)!;
        public OrdersPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
             // Load or bind orders based on _selectedCustomer.CustomerID
            if (_selectedCustomer != null)
            {
                await ViewModel.LoadOrdersAsync(_selectedCustomer);
            }
        }

        private async void OnOrderSelected(object? sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Order selectedOrder)
            {
                await Shell.Current.GoToAsync(nameof(OrderDetailsPage), 
                    new Dictionary<string, object>
                    {
                        // { "SelectedCustomer", _selectedCustomer ?? throw new InvalidOperationException("SelectedCustomer cannot be null") },
                        { "SelectedOrder", selectedOrder }
                    });
            }
        }
    }
}