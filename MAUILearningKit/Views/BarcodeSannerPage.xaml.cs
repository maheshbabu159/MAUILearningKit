using ZXing.Net.Maui;

namespace MAUILearningKit.Views;
public partial class BarcodeSannerPage : ContentPage
{
    public BarcodeSannerPage()
    {
        InitializeComponent();
    }

    private void OnBarcodeDetected(object sender, BarcodeDetectionEventArgs e)
    {
        // Stop scanning
        // barcodeReader.IsDetecting = false;

        // Get scanned text
        var scannedText = e.Results.FirstOrDefault()?.Value;

        MainThread.BeginInvokeOnMainThread(async () =>
        {
            await DisplayAlert("Scanned", $"Product Code: {scannedText}", "OK");

            // You can now fetch product details using the scannedText
            await Shell.Current.GoToAsync(".."); // go back
        });
    }
}