
using MAUILearningKit.ViewModels;

namespace MAUILearningKit.Views
{
    public partial class OrdersPage : ContentPage
    {
        public OrdersPage()
        {
            InitializeComponent();
            BindingContext = new OrdersViewModel();
        }
    }
}