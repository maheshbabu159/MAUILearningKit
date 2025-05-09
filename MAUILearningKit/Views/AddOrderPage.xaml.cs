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
        var newCustomer = new Customer
        {
            CustomerID = CustomerIDEntry.Text,
            CompanyName = CompanyNameEntry.Text,
            ContactName = "ContactNameEntry.Text",
        };

        // TODO: Save to database or API
        // e.g., await _customerService.AddCustomerAsync(newCustomer);
    
        await DisplayAlert("Success", "Customer added successfully!", "OK");
        await Shell.Current.GoToAsync(".."); // navigate back
    }
}