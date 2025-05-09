
using MAUILearningKit.Models;
using MAUILearningKit.ViewModels;

namespace MAUILearningKit.Views;

[QueryProperty(nameof(SelectedCustomer), "SelectedCustomer")]
public partial class AddOrderPage : ContentPage
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

    public AddOrderPage()
    {
        InitializeComponent();
    }

    private void  OnAddScanButtonClicked(object sender, EventArgs e)
    {    
        ShipNameEntry.Text = "Product Name";
        // await Shell.Current.GoToAsync(nameof(BarcodeSannerPage));
      
    }
    private async void OnAddOrderClicked(object sender, EventArgs e)
    {

        // Assuming you have a way to get the selected customer, assign it here
        if (SelectedCustomer == null)
        {
            await DisplayAlert("Error", "No customer selected. Please select a customer before adding an order.", "OK");
            return;
        }

        var newOrder = new Order
        {
            CustomerID = SelectedCustomer.CustomerID!,
            EmployeeID = 5, // Replace with actual employee ID if needed
            OrderDate = DateTime.Now,
            RequiredDate = DateTime.Now,
            ShipAddress = "Sh",
            ShipCity = "ShipC",
            ShipCountry = "Sh",
            ShipName = "ShipN",
            ShipPostalCode = "S",
            ShipRegion = "ShipR",
            ShipVia = 2,
            ShippedDate =  DateTime.Now,

        };
        await ViewModel.AddOrderCommand.ExecuteAsync(newOrder);
    }
}