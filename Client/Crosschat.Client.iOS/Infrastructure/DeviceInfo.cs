using System.Threading.Tasks;
using WeTalk.Client.iOS.Infrastructure;
using WeTalk.Client.Model.Contracts;
using Xamarin.Forms;

[assembly: Dependency(implementorType: typeof(DeviceInfo))]

namespace WeTalk.Client.iOS.Infrastructure
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
