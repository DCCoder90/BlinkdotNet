using Moq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using BlinkdotNet.Net;
using RestSharp;
using Shouldly;
using IRestClient = RestSharp.IRestClient;
using RestClient = BlinkdotNet.Net.RestClient;

namespace Blink.Api.Tests
{
    public class RestClientTest
    {
        private readonly Mock<IRestClient> _clientMock = new Mock<IRestClient>();
        private readonly Mock<IRequestFactory> _requestMock = new Mock<IRequestFactory>();
        private readonly Mock<IResponseHandler> _responseMock = new Mock<IResponseHandler>();
        private readonly CancellationToken _token = new CancellationToken();
        private readonly RestClient _sut;

        public RestClientTest()
        {
            _sut = new RestClient( _requestMock.Object, _responseMock.Object, _token, _clientMock.Object);
        }

#pragma warning disable xUnit1013 // Public method should be marked as test
        public void Dispose()
#pragma warning restore xUnit1013 // Public method should be marked as test
        {
            _requestMock.VerifyAll();
            _responseMock.VerifyAll();
        }

        [Fact]
        public async Task Test_Get_String_Return()
        {
            var uri = new Uri("test-route", UriKind.Relative);
            var auth = new BlinkAuth("testAUth");
            var request = new RestRequest();
            request.RequestFormat = DataFormat.Json;
            var response = new RestResponse();
            var expected = "return";

            _requestMock.Setup(rq => rq.CreateGet(uri)).Returns(request).Verifiable();
            _clientMock.Setup(c => c.Execute(request)).Returns(response);
            _responseMock.Setup(rm => rm.Handle<string>(response)).ReturnsAsync(expected).Verifiable();

            var result = await _sut.Get<string>(uri, auth);

            result.ShouldBeSameAs(expected);
        }

        [Fact]
        public async Task Test_Post_String_Return()
        {
            var uri = new Uri("test-route", UriKind.Relative);
            var auth = new BlinkAuth("testAuth");
            var body = new Dictionary<string, object> { { "test", "value" } };
            var request = new RestRequest();
            var response = new RestResponse(){Content = "TestContent", StatusCode = HttpStatusCode.OK};
            var expected = "response";

            _requestMock.Setup(rq => rq.CreatePost(uri, body)).Returns(request).Verifiable();
            _clientMock.Setup(c => c.Execute(request)).Returns(response);
            _responseMock.Setup(rm => rm.Handle<string>(response)).ReturnsAsync(expected).Verifiable();

            var result = await _sut.Post<string, Dictionary<string, object>>(uri, body, auth);

            result.ShouldBeSameAs(expected);
        }
    }
}
