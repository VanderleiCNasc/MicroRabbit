using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(ServiceCollection services)
        {
            //Domains Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
