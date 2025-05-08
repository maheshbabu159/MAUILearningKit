using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUILearningKit.Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace MAUILearningKit.ViewModels
{
    public partial class OrdersViewModel : ObservableObject
    {
        private readonly HttpClient _httpClient = new() { BaseAddress = new Uri("https://localhost:5043/") };

        [ObservableProperty]
        private ObservableCollection<Order> orders;

        [ObservableProperty]
        private int customerId;

        public OrdersViewModel()
        {
            Orders = [];
            LoadOrdersCommand = new AsyncRelayCommand(LoadOrders);
        }

        public IAsyncRelayCommand LoadOrdersCommand { get; }

        private async Task LoadOrders()
        {
            var response = await _httpClient.GetAsync($"orders?customerId={CustomerId}");
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var ordersList = JsonSerializer.Deserialize<List<Order>>(jsonString);
                Orders = new ObservableCollection<Order>(ordersList ?? []);
            }
        }
    }
}