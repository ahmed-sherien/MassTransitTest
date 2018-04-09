using MassTransit;
using MassTransitTest.Messaging;
using System;
using System.Threading.Tasks;

namespace MassTransitTest.Registration.Service
{
    public class OrderReceivedConsumer : IConsumer<IOrderReceivedEvent>
    {
        public async Task Consume(ConsumeContext<IOrderReceivedEvent> context)
        {
            //Store order registration and get Id
            var id = 12;

            await Console.Out.WriteLineAsync($"Order with id {id} registered");
            await Console.Out.WriteLineAsync($"cid: {context.Message.CorrelationId}");

            //publish event
            await context.Publish<IOrderRegisteredEvent>(new { context.Message.CorrelationId });
        }
    }
}
