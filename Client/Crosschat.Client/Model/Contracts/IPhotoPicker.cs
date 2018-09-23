using System.Threading.Tasks;

namespace WeTalk.Client.Model.Contracts
{
    public interface IPhotoPicker
    {
        Task<byte[]> PickPhoto();
    }
}
