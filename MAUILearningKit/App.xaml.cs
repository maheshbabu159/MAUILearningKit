
using MAUILearningKit.Views;

namespace MAUILearningKit;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(OrdersPage), typeof(OrdersPage));
		Routing.RegisterRoute(nameof(OrderDetailsPage), typeof(OrderDetailsPage));
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}