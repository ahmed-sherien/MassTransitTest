using Automatonymous;
using System;

namespace MassTransitTest.Saga
{
    public class OrderSagaState : SagaStateMachineInstance
    {
        public Guid CorrelationId { get; set; }
        public State CurrentState { get; set; }

        public DateTime ReceivedDateTime { get; set; }
        public DateTime RegisteredDateTime { get; set; }

        public string PickupName { get; set; }
        public string PickupAddress { get; set; }
        public string PickupCity { get; set; }

        public string DeliverName { get; set; }
        public string DeliverAddress { get; set; }
        public string DeliverCity { get; set; }

        public int Weight { get; set; }
        public bool Fragile { get; set; }
        public bool Oversized { get; set; }
    }
}
