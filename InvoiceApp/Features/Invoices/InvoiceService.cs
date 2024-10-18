using InvoiceApp.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace InvoiceApp.Features.Invoices
{
    public class InvoiceService
    {
        private readonly HttpClient _httpClient;

        public InvoiceService(HttpClient? httpClient = null)
        {
            _httpClient = httpClient ?? new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5084");
        }

        public async Task<List<Invoice>> GetInvoicesAsync()
        {
            var response = await _httpClient.GetAsync("/api/invoices");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException("Error fetching invoices");
            }

            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Invoice>>(json);
            if (result == null)
            {
                throw new HttpRequestException("Error converting invoice response");
            }
            return result;
        }

        public async Task<Invoice> GetInvoiceAsync(string cuf)
        {
            var response = await _httpClient.GetAsync($"/api/invoices/{cuf}");

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException($"Error fetching invoice: '{cuf}'");
            }

            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Invoice>(json);
            if (result == null)
            {
                throw new HttpRequestException("Error converting invoice response");
            }
            return result;
        }

    }
}
