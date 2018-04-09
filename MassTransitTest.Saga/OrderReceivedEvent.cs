using MassTransitTest.Messaging;
using System;

namespace MassTransitTest.Saga
{
    public class OrderReceivedEvent : IOrderReceivedEvent
    {
        private readonly OrderSagaState orderSagaState;

        public OrderReceivedEvent(OrderSagaState orderSagaState)
        {
            this.orderSagaState = orderSagaState;
        }

        public Guid CorrelationId => orderSagaState.CorrelationId;
        public string PickupName => orderSagaState.PickupName;
        public string PickupAddress => orderSagaState.PickupAddress;
        public string PickupCity => orderSagaState.PickupCity;
        public string DeliverName => orderSagaState.DeliverName;
        public string DeliverAddress => orderSagaState.DeliverAddress;
        public string DeliverCity => orderSagaState.DeliverCity;
        public int Weight => orderSagaState.Weight;
        public bool Fragile => orderSagaState.Fragile;
        public bool Oversized => orderSagaState.Oversized;
    }
}
