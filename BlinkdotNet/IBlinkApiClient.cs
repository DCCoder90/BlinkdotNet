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
        /// <summary>
        /// Retrieves blink networks
        /// </summary>
        /// <returns>Returns <c>Enumerable</c> of Blink Networks</returns>
        Task<IEnumerable<NetworkDetail>> GetNetworksAsync();

        /// <summary>
        /// Retrieves details for Sync Module
        /// </summary>
        /// <param name="networkId">A valid network id</param>
        /// <returns>Module object containing module details</returns>
        Task<Module> GetSyncModuleAsync(int networkId);

        /// <summary>
        /// Retrieves details that would be present on homescreen
        /// </summary>
        /// <returns>Homescreen object containing details</returns>
        Task<HomeScreen> GetHomeScreenAsync();

        /// <summary>
        /// Retrieves a collection of recent events on the network
        /// </summary>
        /// <param name="networkId">A valid network id</param>
        /// <returns><c>Enumerable</c> of Events</returns>
        Task<IEnumerable<Event>> GetEventsAsync(int networkId);

        /// <summary>
        /// Captures a thumbnail from the current view of the camera
        /// </summary>
        /// <param name="networkId">A valid network id</param>
        /// <param name="cameraId">A valid camera id</param>
        /// <returns>Information on the command that was sent</returns>
        Task<CommandInformation> CaptureThumbnailAsync(int networkId, int cameraId);

        /// <summary>
        /// Captures a video clip from the current view of the camera
        /// </summary>
        /// <param name="networkId">A valid network id</param>
        /// <param name="cameraId">A valid camera id</param>
        /// <returns>Information on the command that was sent</returns>
        Task<CommandInformation> CaptureClipAsync(int networkId, int cameraId);

        /// <summary>
        /// Retrieves a collection of current cameras on the network
        /// </summary>
        /// <param name="networkId">A valid network id</param>
        /// <returns><c>Enumerable</c> of Cameras</returns>
        Task<IEnumerable<Camera>> GetCamerasAsync(int networkId);

        /// <summary>
        /// Retrieves details for a single camera
        /// </summary>
        /// <param name="networkId">A valid network id</param>
        /// <param name="cameraId">A valid camera id</param>
        /// <returns>A Camera object containing camera details</returns>
        Task<Camera> GetCameraByIdAsync(int networkId, int cameraId);

        /// <summary>
        /// Retrieves details from a camera sensor
        /// </summary>
        /// <param name="networkId">A valid network id</param>
        /// <param name="cameraId">A valid camera id</param>
        /// <returns>A SensorInformation object containing the sensor details</returns>
        Task<SensorInformation> GetCameraSensorDetailsAsync(int networkId, int cameraId);

        /// <summary>
        /// Retrieves the total number of videos on the system
        /// </summary>
        /// <returns></returns>
        Task<int> GetVideoCountAsync();

        /// <summary>
        /// Gets information on videos on the system
        /// </summary>
        /// <param name="pageNumber">Page number to get</param>
        /// <returns>An <c>Enumerable</c> of VideoInformation objects</returns>
        Task<IEnumerable<VideoInformation>> GetPagedVideoInfoAsync(int pageNumber = 0);

        /// <summary>
        /// Get information on unwatched videos on the system
        /// </summary>
        /// <returns>An <c>Enumerable</c> of VideoInformation objects</returns>
        Task<IEnumerable<VideoInformation>> GetUnwatchedVideosAsync();

        /// <summary>
        /// Retrieves information about a single video
        /// </summary>
        /// <param name="id">A valid video id</param>
        /// <returns>A VideoInformation object containing details</returns>
        Task<VideoInformation> GetVideoByIdAsync(int id);

        /// <summary>
        /// Retrieves information about current programs on the network
        /// </summary>
        /// <param name="networkId">A valid network id</param>
        /// <returns>A Program object containing details</returns>
        Task<Programs> GetProgramsAsync(int networkId);

        /// <summary>
        /// Retrieves the system health
        /// </summary>
        /// <returns>A <c>string</c> containing the system health</returns>
        Task<string> GetHealthAsync();

        /// <summary>
        /// Retrieves information about applicable regions
        /// </summary>
        /// <returns>A Regions objects with details</returns>
        Task<Regions> GetRegionInfoAsync();

        /// <summary>
        /// Retrieves information about various clients connected to system
        /// </summary>
        /// <returns>An <c>Enumerable</c> of Client objects</returns>
        Task<IEnumerable<Client>> GetClientsAsync();

        /// <summary>
        /// Retrieves a stream containing the bytes to a video or image
        /// </summary>
        /// <param name="fileUri">Valid URL of image or video</param>
        /// <returns><c>Stream</c> containing bytes to file</returns>
        Task<Stream> GetFileAsync(string fileUri);
    }
}
