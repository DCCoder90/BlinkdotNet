using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BlinkdotNet.Entities;
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

        public async Task<IEnumerable<NetworkDetail>> GetNetworks()
        {
            var networks = await _client.Get<NetworkDetails>("networks");
            return networks.networks;
        }

        public async Task<Module> GetSyncModule(int networkId)
        {
            var module = await _client.Get<Syncmodule>("network/" + networkId.ToString() + "/syncmodules");
            return module.syncmodule;
        }

        public async Task<HomeScreen> GetHomeScreen()
        {
            return await _client.Get<HomeScreen>("homescreen");
        }

        public async Task<IEnumerable<Event>> GetEvents(int networkId)
        {
            var events = await _client.Get<EventCollection>("events/network/" + networkId.ToString());
            return events.@event;
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

        public async Task<IEnumerable<Camera>> GetCameras(int networkId)
        {
            var cameras = await _client.Get<CameraCollection>("network/"+networkId.ToString()+"/cameras");
            return cameras.devicestatus;
        }

        public async Task<Camera> GetCameraById(int networkId, int cameraId)
        {
            var camera = await _client.Get<CameraDetails>("network/"+networkId.ToString()+"/camera/"+cameraId.ToString());
            return camera.camera_status;
        }

        public async Task<SensorInformation> GetCameraSensorDetails(int networkId, int cameraId)
        {
            return await _client.Get<SensorInformation>("network/" + networkId.ToString() + "/camera/" +
                                                    cameraId.ToString() + "/signals");
        }

        public async Task<int> GetVideoCount()
        {
            var count= await _client.Get<IDictionary<string, int>>("videos/count");
            return count["count"];
        }

        public async Task<IEnumerable<VideoInformation>> GetPagedVideoInfo(int pageNumber=0)
        {
            return await _client.Get<IEnumerable<VideoInformation>>("videos/page/" + pageNumber.ToString());
        }

        public async Task<IEnumerable<VideoInformation>> GetUnwatchedVideos()
        {
            return await _client.Get<IEnumerable<VideoInformation>>("videos/unwatched");
        }

        public async Task<VideoInformation> GetVideoById(int id)
        {
            return await _client.Get<VideoInformation>("video/" + id.ToString());
        }

        public async Task<Programs> GetPrograms(int networkId)
        {
            return await _client.Get<Programs>("networks/"+networkId.ToString()+"/programs");
        }

        public async Task<string> GetHealth()
        {
            var result = await _client.Get<IDictionary<string, string>>("health");
            return result["health"];
        }

        public async Task<Regions> GetRegionInfo()
        {
            var result = await _client.Get<RegionInfo<Regions>>("regions");
            return result.regions;
        }

        public async Task<IEnumerable<Client>> GetClients()
        {
            return await _client.Get<IEnumerable<Client>>("account/clients");
        }

        public async Task<Stream> GetFile(string fileUri)
        {
            var videoData = await _client.Get<byte[]>(fileUri);
            return new MemoryStream(videoData);
        }
    }
}