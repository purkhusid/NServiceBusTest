using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BustStop.Contracts;
using NServiceBus;

namespace BusStop.Api.Controllers
{
    public class OrdersController : ApiController
    {
        public IBus Bus { get; set; }

        public Guid Get()
        {
            var order = new PlaceOrder
            {
                OrderId = Guid.NewGuid(),
                CustomerId = Guid.NewGuid(),
                ProductId = Guid.NewGuid()
            };

            Bus.Send(order);

            return order.OrderId;
        }
    }
}
