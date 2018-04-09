using MassTransit;
using MassTransit.RabbitMqTransport;
using System;

namespace MassTransitTest.Messaging
{
    public static class BusConfigurator
    {
        public static IBusControl ConfigureBus(Action<IRabbitMqBusFactoryConfigurator, IRabbitMqHost> registerationAction = null)
        {
            return Bus.Factory.CreateUsingRabbitMq(config =>
            {
                var host = config.Host(new Uri(RabbitMQConstants.RabbitMqUri), h =>
                {
                    h.Username(RabbitMQConstants.UserName);
                    h.Password(RabbitMQConstants.Password);
                });

                registerationAction?.Invoke(config, host);
            });
        }
    }
}
