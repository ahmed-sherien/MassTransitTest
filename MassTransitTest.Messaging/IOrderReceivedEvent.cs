using System;

namespace MassTransitTest.Messaging
{
    public interface IOrderReceivedEvent
    {
        Guid CorrelationId { get; }

        string PickupName { get; }
        string PickupAddress { get; }
        string PickupCity { get; }

        string DeliverName { get; }
        string DeliverAddress { get; }
        string DeliverCity { get; }

        int Weight { get; }
        bool Fragile { get; }
        bool Oversized { get; }
    }
}
