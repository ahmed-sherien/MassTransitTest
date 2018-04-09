using MassTransit;
using MassTransitTest.Messaging;
using System;
using System.Threading.Tasks;

namespace MassTransitTest.Notification.Service
{
    public class OrderRegisteredConsumer : IConsumer<IOrderRegisteredEvent>
    {
        public async Task Consume(ConsumeContext<IOrderRegisteredEvent> context)
        {
            //Send notification to user
            await Console.Out.WriteLineAsync($"Customer notification sent: Order cid {context.Message.CorrelationId}");
        }
    }
}
