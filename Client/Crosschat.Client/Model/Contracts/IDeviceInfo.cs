using System.Threading.Tasks;

namespace WeTalk.Client.Model.Contracts
{
    public interface IDeviceInfo
    {
        Task InitAsync();

        string Huid { get; }

        string PushUri { get; }
    }
}