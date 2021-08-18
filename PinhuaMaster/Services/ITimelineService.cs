using System;
using System.Collections.Generic;

namespace PinhuaMaster.Services
{
    public interface ITimelineService
    {
        IList<Order> GetOrders();
        IList<Delivery> GetDeliveryOrders();
        IList<DateTime?> GetTimelineDates();
        IList<TimelineData> GetTimelineData();
    }
}