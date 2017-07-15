﻿using System;
using DotNetCore.CAP.RabbitMQ;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetCore.CAP
{
    public class RabbitMQCapOptionsExtension : ICapOptionsExtension
    {
        private Action<RabbitMQOptions> _configure;

        public RabbitMQCapOptionsExtension(Action<RabbitMQOptions> configure)
        {
            _configure = configure;
        }

        public void AddServices(IServiceCollection services)
        {
            services.Configure(_configure);

            var rabbitMQOptions = new RabbitMQOptions();
            _configure(rabbitMQOptions);

            services.AddSingleton(rabbitMQOptions);

            services.AddSingleton<IConsumerClientFactory, RabbitMQConsumerClientFactory>();
            services.AddTransient<IQueueExecutor, PublishQueueExecutor>();
        }
    }
}
