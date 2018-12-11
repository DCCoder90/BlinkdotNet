namespace BlinkdotNet.Net.Entities
{
    internal class RegionInfo<T>
    {
        public string preferred { get; set; }
        public T regions { get; set; }
    }
}