using System;

namespace WeTalk.Client.Model.Entities.Messages
{
    public class RemovedModershipNotificationEvent : Event
    {
        public string ActorName { get; set; }

        public string TargetName { get; set; }

        public Guid TargetId { get; set; }
    }
}
