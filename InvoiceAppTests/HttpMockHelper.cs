using Moq.Protected;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAppTests
{
    internal class HttpMockHelper
    {
        public static HttpClient CreateClient(object mockedResponse, HttpStatusCode statusCode)
        {
            var httpMessageHandlerMock = new Mock<HttpMessageHandler>();

            HttpResponseMessage httpResponseMessage = new()
            {
                Content = JsonContent.Create(mockedResponse),
                StatusCode = statusCode
            };
            var setupMock = httpMessageHandlerMock
           .Protected() // <= this is most important part that it need to setup.
           .Setup<Task<HttpResponseMessage>>(
               "SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>());

            setupMock.ReturnsAsync(httpResponseMessage);

            var httpClient = new HttpClient(httpMessageHandlerMock.Object);

            return httpClient;
        }

    }
}
