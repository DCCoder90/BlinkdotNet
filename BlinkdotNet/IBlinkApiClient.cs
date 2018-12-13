using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using BlinkdotNet.Entities;
using BlinkdotNet.Net;
using BlinkdotNet.Net.Entities;

namespace BlinkdotNet
{
    public interface IBlinkApiClient
    {
        Task<IEnumerable<NetworkDetail>> GetNetworksAsync();
        Task<Module> GetSyncModuleAsync(int networkId);
        Task<HomeScreen> GetHomeScreenAsync();
        Task<IEnumerable<Event>> GetEventsAsync(int networkId);
        Task<CommandInformation> CaptureThumbnailAsync(int networkId, int cameraId);
        Task<CommandInformation> CaptureClipAsync(int networkId, int cameraId);
        Task<IEnumerable<Camera>> GetCamerasAsync(int networkId);
        Task<Camera> GetCameraByIdAsync(int networkId, int cameraId);
        Task<SensorInformation> GetCameraSensorDetailsAsync(int networkId, int cameraId);
        Task<int> GetVideoCountAsync();
        Task<IEnumerable<VideoInformation>> GetPagedVideoInfoAsync(int pageNumber = 0);
        Task<IEnumerable<VideoInformation>> GetUnwatchedVideosAsync();
        Task<VideoInformation> GetVideoByIdAsync(int id);
        Task<Programs> GetProgramsAsync(int networkId);
        Task<string> GetHealthAsync();
        Task<Regions> GetRegionInfoAsync();
        Task<IEnumerable<Client>> GetClientsAsync();
        Task<Stream> GetFileAsync(string fileUri);
    }
}
