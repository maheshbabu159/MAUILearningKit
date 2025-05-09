using Microsoft.AspNetCore.SignalR.Client;

public class RealtimeService
{
    private HubConnection? _connection;

    public async Task ConnectAsync()
    {
        _connection = new HubConnectionBuilder()
            .WithUrl("https://localhost:5043/productHub")
            .WithAutomaticReconnect()
            .Build();

        _connection.On<string>("ReceiveProduct", (productName) =>
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                var mainPage = Application.Current?.Windows.FirstOrDefault()?.Page;
                if (mainPage != null)
                {
                    mainPage.DisplayAlert("New Product", $"Received: {productName}", "OK");
                }
            });
        });

        await _connection.StartAsync();
    }
}