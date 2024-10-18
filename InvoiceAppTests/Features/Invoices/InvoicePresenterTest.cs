
using Moq;
using Moq.Protected;
using System.Net.Http.Json;

using InvoiceApp.Features.Invoices;
using InvoiceApp.Models;
using System.Net;

namespace InvoiceAppTests.Features.Invoices
{
    public class InvoicePresenterTest
    {
        [Fact]
        public async void TestCorrectDataLoaded()
        {
            var mockResponse = new[]
            {
    new { cuf = "123", nit = "9876543210", customerName = "John Doe", totalAmount = 100.50m, createdAt = DateTime.Now, status = 1 },
            };

            var mockedClient = HttpMockHelper.CreateClient(mockResponse, HttpStatusCode.OK);
            var invoiceService = new InvoiceService(mockedClient);
            var viewMock = new Mock<IInvoiceView>();
            viewMock.SetupProperty(v => v.Invoices);
            var view = viewMock.Object;

            var invoicePresenter = new InvoicePresenter(view, invoiceService);
            await Task.Run(() =>
                invoicePresenter.OnLoadFetchInvoices(new { }, EventArgs.Empty)
            );
            Assert.NotNull(view.Invoices);
            Assert.Equal(view.Invoices[0].Cuf, mockResponse[0].cuf);
            Assert.False(view.IsLoading);
        }

        [Fact]
        public async void TestErrorMessageIsSet()
        {
            var mockResponse = Array.Empty<object>();

            var mockedClient = HttpMockHelper.CreateClient(mockResponse, HttpStatusCode.InternalServerError);
            var invoiceService = new InvoiceService(mockedClient);
            var viewMock = new Mock<IInvoiceView>();
            var view = viewMock.Object;

            var invoicePresenter = new InvoicePresenter(view, invoiceService);

            await Task.Run(() =>
            invoicePresenter.OnLoadFetchInvoices(new { }, EventArgs.Empty)
            );
            Assert.Null(view.Invoices);
            Assert.NotEqual("", view.ErrorMessage);
            Assert.False(view.IsLoading);
        }

        [Fact]
        public async void TestLoadingVariable()
        {
            List<Invoice> mockResponse = [];

            var mockedClient = HttpMockHelper.CreateClient(mockResponse, HttpStatusCode.OK);
            var invoiceService = new InvoiceService(mockedClient);
            var viewMock = new Mock<IInvoiceView>();
            var view = viewMock.Object;

            var invoicePresenter = new InvoicePresenter(view, invoiceService);
            await Task.Run(() =>
                            invoicePresenter.OnLoadFetchInvoices(new { }, EventArgs.Empty)
            );
            viewMock.VerifySet(v => v.IsLoading = true, Times.Once());

            Assert.False(view.IsLoading);
        }
    }
}