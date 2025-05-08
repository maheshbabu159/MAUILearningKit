
using MAUILearningKit.ViewModels;

namespace MAUILearningKit.Views
{
    public partial class OrdersPage : ContentPage
    {
        private OrdersViewModel ViewModel => (BindingContext as OrdersViewModel)!;
        public OrdersPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.LoadOrdersCommand.ExecuteAsync(null);
        }
    }
}