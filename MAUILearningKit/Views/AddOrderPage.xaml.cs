using MAUILearningKit.Models;

namespace MAUILearningKit.Views;

public partial class AddOrderPage : ContentPage
{
    public AddOrderPage()
    {
        InitializeComponent();
    }

    private async void OnAddOrderClicked(object sender, EventArgs e)
    {
        // string shortGuid = Guid.NewGuid().ToString("N").Substring(0, 4);
        // var newCustomer = new Order
        // {
        //     OrderID = shortGuid,
        //     CustomerID = CustomerIdEntry.Text,
        //     ShipCountry = ShipCountryEntry.Text,
        //     ShipName = ShipNameEntry.Text,
        //     OrderDate = DateTime.Now // Set the required OrderDate property
        // };

        // TODO: Save to database or API
        // e.g., await _customerService.AddCustomerAsync(newCustomer);
    
        await DisplayAlert("Success", "Customer added successfully!", "OK");
        await Shell.Current.GoToAsync(".."); // navigate back
    }
}