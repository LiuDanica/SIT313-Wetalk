using System.Threading.Tasks;
using WeTalk.Client.Model.Entities;

namespace WeTalk.Client.Model.Contracts
{
    public interface IContactsRepository
    {
        Task<Contact[]> GetAllAsync();
    }
}
