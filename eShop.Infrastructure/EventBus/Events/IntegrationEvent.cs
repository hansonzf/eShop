using System;

namespace eShop.Infrastructure.EventBus.Events
{
    public class IntegrationEvent
    {
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            OccurredTime = DateTime.Now;
        }

        public Guid Id { get; }
        public DateTime OccurredTime { get; }
    }
}
