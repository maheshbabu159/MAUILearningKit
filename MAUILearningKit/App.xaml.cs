
using MAUILearningKit.Views;

namespace MAUILearningKit;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(OrdersPage), typeof(OrdersPage));
		Routing.RegisterRoute(nameof(OrderDetailsPage), typeof(OrderDetailsPage));
		Routing.RegisterRoute(nameof(AddCustomerPage), typeof(AddCustomerPage));
		Routing.RegisterRoute(nameof(AddOrderPage), typeof(AddOrderPage));
		Routing.RegisterRoute(nameof(BarcodeSannerPage), typeof(BarcodeSannerPage));

		InitializeRealtimeServiceAsync();
	}

	private async void InitializeRealtimeServiceAsync()
	{
		var realtimeService = new RealtimeService();
		await realtimeService.ConnectAsync();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}