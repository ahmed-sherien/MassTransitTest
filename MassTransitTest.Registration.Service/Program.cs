using MassTransit;
using MassTransitTest.Messaging;
using System;

namespace MassTransitTest.Registration.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Registration";

            var bus = BusConfigurator.ConfigureBus((config, host) =>
            {
                config.ReceiveEndpoint(host, RabbitMQConstants.RegisterOrderServiceQueue, e =>
                {
                    e.Consumer<OrderReceivedConsumer>();
                });
            });

            bus.Start();

            Console.WriteLine("Listening for Register order commands... Press enter to exit");
            Console.ReadLine();

            bus.Stop();
        }
    }
}
