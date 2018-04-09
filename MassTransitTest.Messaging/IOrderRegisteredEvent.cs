using System;

namespace MassTransitTest.Messaging
{
    public interface IOrderRegisteredEvent
    {
        Guid CorrelationId { get; }
    }
}
