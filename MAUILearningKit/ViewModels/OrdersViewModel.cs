using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUILearningKit.Models;
using System.Collections.ObjectModel;
using System.Text.Json;
using MAUILearningKit.Services;

namespace MAUILearningKit.ViewModels
{
    public partial class OrdersViewModel : ObservableObject
    {
        private readonly ApiService _apiService = new();

        [ObservableProperty]
        private List<Order> orders = [];

        [ObservableProperty]
        private Customer? selectedCustomer;

        [RelayCommand]
        public async Task LoadOrdersAsync(Customer? selectedCustomer)
        {
            SelectedCustomer = selectedCustomer;
        
            if (SelectedCustomer != null)
            {
                if (!string.IsNullOrEmpty(SelectedCustomer.CustomerID))
                {
                    Orders = await _apiService.GetOrdersByCustomerAsync(SelectedCustomer.CustomerID);
                }
            }
        }

        [RelayCommand]
        public async Task AddOrderAsync(Order order)
        {
            if (await _apiService.AddOrderAsync(order))
            {
                Orders.Add(order);
            } else {
                 await Shell.Current.DisplayAlert("Error", "Failed to add order.", "OK");
            }
            _ = Shell.Current.GoToAsync(".."); // navigates back one page
        }
    }
}