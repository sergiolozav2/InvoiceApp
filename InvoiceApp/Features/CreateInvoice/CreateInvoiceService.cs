using InvoiceApp.Features.CreateInvoice.Models;
using InvoiceApp.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace InvoiceApp.Features.CreateInvoice
{
    public class CreateInvoiceService
    {
        private readonly HttpClient _httpClient;

        public CreateInvoiceService(HttpClient? httpClient = null)
        {
            _httpClient = httpClient ?? new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5084");
        }

        public async Task CreateInvoiceAsync(CreateInvoiceRequestDto invoice)
        {
            var jsonContent = JsonConvert.SerializeObject(invoice);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("/api/invoices", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new HttpRequestException("Error creating invoice");
            }
        }

    }
}
