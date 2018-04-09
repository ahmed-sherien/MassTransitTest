using MassTransit;
using MassTransitTest.Messaging;
using System;

namespace MassTransitTest.Notification.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Notification";

            var bus = BusConfigurator.ConfigureBus((cfg, host) =>
            {
                cfg.ReceiveEndpoint(host, RabbitMQConstants.NotificationServiceQueue, e =>
                {
                    e.Consumer<OrderRegisteredConsumer>();
                });
            });

            bus.Start();

            Console.WriteLine("Listening for Order registered events... Press enter to exit");
            Console.ReadLine();

            bus.Stop();
        }
    }
}
