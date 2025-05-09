using MAUILearningKit.Models;
using MAUILearningKit.ViewModels;

namespace MAUILearningKit.Views;

public partial class AddCustomerPage : ContentPage
{
    private CustomersViewModel ViewModel => (BindingContext as CustomersViewModel)!;

    public AddCustomerPage()
    {
        InitializeComponent();
    }

    private async void OnAddCustomerClicked(object sender, EventArgs e)
    {
        string shortGuid = Guid.NewGuid().ToString("N").Substring(0, 4);
        var newCustomer = new Customer
        {
            CustomerID = shortGuid,
            CompanyName = CompanyNameEntry.Text,
            ContactName = ContactNameEntry.Text,
        };
        await ViewModel.AddCustomerCommand.ExecuteAsync(newCustomer);
    }
}