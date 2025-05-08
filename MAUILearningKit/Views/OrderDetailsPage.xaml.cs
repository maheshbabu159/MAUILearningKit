
using MAUILearningKit.ViewModels;
using MAUILearningKit.Models;

namespace MAUILearningKit.Views
{
    // [QueryProperty(nameof(SelectedCustomer), "SelectedCustomer")]
    [QueryProperty(nameof(SelectedOrder), "SelectedOrder")]

    public partial class OrderDetailsPage : ContentPage
    {   public Order SelectedOrder
        {
            get => (BindingContext as Order) ?? throw new NullReferenceException("BindingContext is not an Order.");
            set => BindingContext = value;
        }
        private OrdersViewModel ViewModel => (BindingContext as OrdersViewModel)!;
        public OrderDetailsPage()
        {
            InitializeComponent();
        }
    }
}