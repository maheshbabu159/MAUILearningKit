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
                Orders = await _apiService.GetOrdersByCustomerAsync(SelectedCustomer.CustomerID);
            }
        }
    }
}