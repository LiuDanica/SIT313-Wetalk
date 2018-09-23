using System.Threading.Tasks;
using WeTalk.Client.Droid.Infrastructure;
using WeTalk.Client.Model.Contracts;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceInfo))]

namespace WeTalk.Client.Droid.Infrastructure
{
    public class DeviceInfo : IDeviceInfo
    {
        public Task InitAsync()
        {
            return Task.FromResult(false);
        }

        public string Huid { get { return "TODO:HUID"; }}
        public string PushUri { get; private set; }
    }
}
