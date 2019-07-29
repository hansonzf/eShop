using System.Threading.Tasks;

namespace eShop.Infrastructure.EventBus.Abstractions
{
    public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}
