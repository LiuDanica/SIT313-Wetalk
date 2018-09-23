using WeTalk.Client.Model.Entities.Messages;
using WeTalk.Client.Seedwork;

namespace WeTalk.Client.ViewModels
{
    public class EventViewModel : ViewModelBase
    {
        private readonly Event _eventPoco;

        public EventViewModel(Event eventPoco)
        {
            _eventPoco = eventPoco;
        }
    }
}
