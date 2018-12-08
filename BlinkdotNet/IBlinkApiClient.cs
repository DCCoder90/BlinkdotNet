using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BlinkdotNet.Net;
using BlinkdotNet.Net.Entities;

namespace BlinkdotNet
{
    public interface IBlinkApiClient
    {
        Task<NetworkDetails> GetNetworks();
        Task<Syncmodule> GetSyncModule(int networkId);
        Task<HomeScreen> GetHomeScreen();
        Task<EventCollection> GetEvents(int networkId);
        Task<CommandInformation> CaptureThumbnail(int networkId, int cameraId);
        Task<CommandInformation> CaptureClip(int networkId, int cameraId);
        Task<CameraCollection> GetCameras(int networkId);
        Task<CameraDetails> GetCameraDetails(int networkId, int cameraId);
        Task<SensorInformation> GetCameraSensorDetails(int networkId, int cameraId);

    }
}
