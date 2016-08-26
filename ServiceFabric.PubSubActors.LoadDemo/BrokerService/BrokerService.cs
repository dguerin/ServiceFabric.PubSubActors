﻿using System;
using System.Fabric;

namespace BrokerService
{
    /// <summary>
    /// Broker for pub sub messaging.
    /// </summary>
    internal sealed class BrokerService : ServiceFabric.PubSubActors.BrokerService
    {
        public BrokerService(StatefulServiceContext context)
            : base(context)
        {
            ServiceEventSourceMessageCallback = (message) => ServiceEventSource.Current.ServiceMessage(this, message);

            Period = TimeSpan.FromMilliseconds(200);
            DueTime = TimeSpan.FromSeconds(10);
        }
    }
}