namespace MassTransitTest.Messaging
{
    public static class RabbitMQConstants
    {
        public const string RabbitMqUri = "rabbitmq://localhost/masstransittest/";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string RegisterOrderServiceQueue = "registerorder.service";
        public const string NotificationServiceQueue = "notification.service";
        public const string SagaQueue = "saga.service";
    }
}
