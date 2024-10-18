
using Moq;
using Moq.Protected;
using System.Net.Http.Json;

using InvoiceApp.Features.Invoices;
using System.Net;

namespace InvoiceAppTests.Features.Invoices
{
    public class InvoiceServiceTest
    {
        [Fact]
        public async void TestCorrectDataSerialization()
        {
            var mockResponse = new[]
            {
    new { cuf = "123", nit = "9876543210", customerName = "John Doe", totalAmount = 100.50m, createdAt = DateTime.Now, status = 1 },
            };

            var mockedClient = HttpMockHelper.CreateClient(mockResponse, HttpStatusCode.OK);
            var invoiceService = new InvoiceService(mockedClient);
            var result = await invoiceService.GetInvoicesAsync();
            Console.WriteLine(result[0].CustomerName);
            Assert.Equal(result[0].Cuf, mockResponse[0].cuf);
            Assert.Equal(result[0].Nit, mockResponse[0].nit);
            Assert.Equal(result[0].CustomerName, mockResponse[0].customerName);
            Assert.Equal(result[0].TotalAmount, mockResponse[0].totalAmount);
        }


        [Fact]
        public async void TestThrowsOnException()
        {
            HttpResponseMessage mockResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.InternalServerError
            };

            var mockedClient = HttpMockHelper.CreateClient(mockResponse, HttpStatusCode.InternalServerError);
            var invoiceService = new InvoiceService(mockedClient);
            Task result() => invoiceService.GetInvoicesAsync();
            await Assert.ThrowsAsync<HttpRequestException>(result);

        }
    }
}