using MAUILearningKit.Models;

namespace MAUILearningKit.Services;
using System.Net.Http.Json;
using System.Collections.ObjectModel;
using System.Text.Json;

public class ApiService
{
    private readonly HttpClient _httpClient;
   
    public ApiService()
    {
            var handler = new HttpClientHandler();
#if DEBUG
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) =>
            {
                if (cert != null && cert.Issuer.Equals("CN=localhost"))
                    return true;
                return errors == System.Net.Security.SslPolicyErrors.None;
            };
#endif
            _httpClient = new HttpClient(handler) { BaseAddress = new Uri("https://localhost:5043/") };
    }

    private readonly JsonSerializerOptions options = new()
    {
        PropertyNameCaseInsensitive = true
    };
    
    public async Task<List<Customer>> GetCustomersAsync()
    {
        var response = await _httpClient.GetAsync("api/customers");
        var responseContent = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<List<Customer>>(responseContent, options) ?? [];
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}