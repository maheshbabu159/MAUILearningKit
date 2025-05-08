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
    }
}