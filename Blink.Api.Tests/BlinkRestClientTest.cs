using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlinkdotNet.Net;
using BlinkdotNet.Net.Entities;
using Moq;
using RestSharp;
using Shouldly;
using Xunit;
using IRestClient = BlinkdotNet.Net.IRestClient;

namespace Blink.Api.Tests
{
    public class BlinkRestClientTest
    {

        private readonly BlinkRestClient _sut;
        //private  readonly Mock<RestSharp.IRestClient> _restSharpClientMock = new Mock<RestSharp.IRestClient>();
        private readonly Mock<BlinkdotNet.Net.IRestClient> _restClientMock = new Mock<IRestClient>();
        private const string _username = "testuser@example.com";
        private const string _password = "myPassword";

        private BlinkAuth _auth = new BlinkAuth() {
            authtoken = new BlinkAuth.Authtoken(){authtoken = "testAuth"},
            region = new Dictionary<string, string>(){{"myRegion", "somevalue"}}
        };

        public BlinkRestClientTest()
        {
            var request = new RestRequest("login", Method.POST);
            var authBody = new AuthenticationBody(_username, _password, "iPhone 9.2 | 2.2 | 222");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(authBody);

            Mock<IRestResponse<BlinkAuth>> response = new Mock<IRestResponse<BlinkAuth>>();
            response.SetupGet(x => x.Data).Returns(_auth);

            _restClientMock.Setup(x => x.BaseClient.Execute<BlinkAuth>(It.IsAny<RestRequest>())).Returns(response.Object);
            _sut = new BlinkRestClient(_restClientMock.Object,_username,_password);
        }

#pragma warning disable xUnit1013 // Public method should be marked as test
        public void Dispose()
#pragma warning restore xUnit1013 // Public method should be marked as test
        {
            _restClientMock.VerifyAll();
        }

        [Fact]
        public async Task Test_Get()
        {
            var returnData = "mydata";
            _restClientMock.Setup(x => x.Get<string>(new Uri("testroute",UriKind.Relative),_auth)).ReturnsAsync(returnData);

            var myreturn = await _sut.Get<string>("testroute");

            myreturn.ShouldBeSameAs(returnData);
        }

        [Fact]
        public async Task Test_Post()
        {
            var returnData = "mydata";
            _restClientMock.Setup(x => x.Post<string,string>(new Uri("testroute", UriKind.Relative), "body",_auth)).ReturnsAsync(returnData);

            var myreturn = await _sut.Post<string,string>("testroute","body");

            myreturn.ShouldBeSameAs(returnData);
        }
    }
}
