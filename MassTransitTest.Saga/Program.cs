using Automatonymous;
using MassTransit;
using MassTransit.Saga;
using MassTransitTest.Messaging;
using System;

namespace MassTransitTest.Saga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Saga";

            var saga = new OrderSaga();
            var repo = new InMemorySagaRepository<OrderSagaState>();

            var bus = BusConfigurator.ConfigureBus((config, host) =>
            {
                config.ReceiveEndpoint(host, RabbitMQConstants.SagaQueue, e =>
                {
                    e.StateMachineSaga(saga, repo);
                });
            });

            bus.Start();

            Console.WriteLine("Saga active... Press enter to exit");
            Console.ReadLine();

            bus.Stop();
        }
    }
}
