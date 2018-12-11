using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlinkdotNet.Entities;
using BlinkdotNet.Net;
using BlinkdotNet.Net.Entities;

namespace BlinkdotNet
{
    public interface IBlinkApiClient
    {
        Task<IEnumerable<NetworkDetail>> GetNetworks();
        Task<Module> GetSyncModule(int networkId);
        Task<HomeScreen> GetHomeScreen();
        Task<IEnumerable<Event>> GetEvents(int networkId);
        Task<CommandInformation> CaptureThumbnail(int networkId, int cameraId);
        Task<CommandInformation> CaptureClip(int networkId, int cameraId);
        Task<IEnumerable<Camera>> GetCameras(int networkId);
        Task<Camera> GetCameraById(int networkId, int cameraId);
        Task<SensorInformation> GetCameraSensorDetails(int networkId, int cameraId);
        Task<int> GetVideoCount();
        Task<IEnumerable<VideoInformation>> GetPagedVideoInfo(int pageNumber = 0);
        Task<IEnumerable<VideoInformation>> GetUnwatchedVideos();
        Task<VideoInformation> GetVideoById(int id);
        Task<Programs> GetPrograms(int networkId);
    }
}
