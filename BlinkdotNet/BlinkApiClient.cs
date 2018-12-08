using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BlinkdotNet.Net;
using BlinkdotNet.Net.Entities;

[assembly: InternalsVisibleTo("Blink.Api.Tests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace BlinkdotNet
{
    public class BlinkApiClient : IBlinkApiClient
    {
        private readonly IBlinkRestClient _client;

        public BlinkApiClient(string username, string password)
        {
            RestClientFactory factory = new RestClientFactory(username, password);
            _client = factory.CreateUsa();
        }

        public async Task<NetworkDetails> GetNetworks()
        {
            return await _client.Get<NetworkDetails>("networks");
        }

        public async Task<Syncmodule> GetSyncModule(int networkId)
        {
            return await _client.Get<Syncmodule>("network/" + networkId.ToString() + "/syncmodules");
        }

        public async Task<HomeScreen> GetHomeScreen()
        {
            return await _client.Get<HomeScreen>("homescreen");
        }

        public async Task<EventCollection> GetEvents(int networkId)
        {
            return await _client.Get<EventCollection>("events/network/" + networkId.ToString());
        }

        public async Task<CommandInformation> CaptureThumbnail(int networkId, int cameraId)
        {
            return await _client.Get<CommandInformation>("network/" + networkId.ToString() + "/camera/" +
                                                      cameraId.ToString() + "/thumbnail");
        }

        public async Task<CommandInformation> CaptureClip(int networkId, int cameraId)
        {
            return await _client.Get<CommandInformation>("network/" + networkId.ToString() + "/camera/" +
                                                         cameraId.ToString() + "/clip");
        }

        public async Task<CameraCollection> GetCameras(int networkId)
        {
            
            return await _client.Get<CameraCollection>("network/"+networkId.ToString()+"/cameras");
        }

        public async Task<CameraDetails> GetCameraDetails(int networkId, int cameraId)
        {
            return await _client.Get<CameraDetails>("network/"+networkId.ToString()+"/camera/"+cameraId.ToString());

        }

        public async Task<SensorInformation> GetCameraSensorDetails(int networkId, int cameraId)
        {
            return await _client.Get<SensorInformation>("network/" + networkId.ToString() + "/camera/" +
                                                    cameraId.ToString() + "/signals");

        }
    }
}