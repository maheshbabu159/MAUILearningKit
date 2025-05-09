using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUILearningKit.Models;
using MAUILearningKit.Services;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Windows.Input;


namespace MAUILearningKit.ViewModels
{
    public partial class CustomersViewModel : ObservableObject
    {
        private readonly ApiService _apiService = new();

        [ObservableProperty]
        private List<Customer> customers = [];
        
        [RelayCommand]
        public async Task LoadCustomersAsync()
        {
            Customers = await _apiService.GetCustomersAsync();
        }
        [RelayCommand]
        public async Task AddCustomerAsync(Customer customer)
        {
            if (await _apiService.AddCustomerAsync(customer))
            {
                Customers.Add(customer);
                // Handle success (navigate back, show success message)
                
                await Shell.Current.DisplayAlert("Error", "Failed to add customer.", "OK");

                // For example, navigate back
                _ = Shell.Current.GoToAsync(".."); // navigates back one page
            }
        }
    }
}