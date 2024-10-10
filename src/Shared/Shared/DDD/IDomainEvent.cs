using MediatR;

namespace Shared.DDD
{
    public interface IDomainEvent : INotification
    {
        Guid EventId => Guid.NewGuid();
        public DateTime OccuredON => DateTime.Now;
        public string EventType => GetType().AssemblyQualifiedName!;
    }
}
