using Microsoft.EntityFrameworkCore;
using PinhuaMaster.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PinhuaMaster.Data.Entities.Pinhua;

namespace PinhuaMaster.Services
{
    public class Order
    {
        public NewOrderMain Main { get; set; }
        public IList<NewOrderDetails> Details { get; set; }
    }
    public class Delivery
    {
        public NewDeliveryMain Main { get; set; }
        public IList<DeliveryDetails> Details { get; set; }
    }
    public class DeliveryDetails
    {
        public string DetailsId { get; set; }
        public string Description { get; set; }
        public int? Length { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Amount { get; set; }
        public string DeliveryId { get; set; }
    }
    public class Collection
    {
        public NCollectionMain Main { get; set; }
    }

    public class TimelineData
    {
        public DateTime? Date { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<Delivery> DeliveryOrders { get; set; }
        public IList<Collection> Collections { get; set; }
    }

    /// <summary>
    /// 菜单服务
    /// </summary>
    public class TimelineService : ITimelineService
    {
        private readonly PinhuaContext _context;
        public TimelineService(PinhuaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 生成导航菜单
        /// </summary>
        /// <returns></returns>
        public IList<Order> GetOrders()
        {
            var Orders = new List<Order>();
            var mainList = _context.NewOrderMain.OrderByDescending(p => p.OrderDate).ThenByDescending(p => p.OrderId).ToList();
            foreach (var main in mainList)
            {
                var details = _context.NewOrderDetails.Where(p => p.OrderId == main.OrderId).OrderBy(p => p.DetailsId).ToList();
                Orders.Add(new Order
                {
                    Main = main,
                    Details = details
                });
            }
            return Orders;
        }

        public IList<Delivery> GetDeliveryOrders()
        {
            var DeliveryOrders = new List<Delivery>();
            var mainList = _context.NewDeliveryMain.OrderByDescending(p => p.DeliveryDate).OrderByDescending(p => p.DeliveryId).ToList();
            foreach (var main in mainList)
            {
                var details = (from dd in _context.NewDeliveryDetails.Where(p => p.DeliveryId == main.DeliveryId)
                               join od in _context.NewOrderDetails on new
                               {
                                   A = dd.DetailsId,
                                   B = main.OrderSource
                               } equals new
                               {
                                   A = od.DetailsId,
                                   B = od.OrderId
                               }
                               select new DeliveryDetails
                               {
                                   DetailsId = dd.DetailsId,
                                   Description = od.Description,
                                   Length = od.Length,
                                   Width = od.Width,
                                   Height = od.Height,
                                   Qty = dd.Qty,
                                   Amount = dd.Amount,
                                   DeliveryId = dd.DeliveryId
                               }).ToList();
                DeliveryOrders.Add(new Delivery
                {
                    Main = main,
                    Details = details
                });
            }
            return DeliveryOrders;
        }

        public IList<Collection> GetCollections()
        {
            var collectionList = new List<Collection>();
            var mainList = _context.NCollectionMain.OrderByDescending(p => p.CollectionDate).ThenByDescending(p => p.CollectionId).ToList();
            foreach (var main in mainList)
            {
                collectionList.Add(new Collection
                {
                    Main = main
                });
            }
            return collectionList;
        }

        public IList<DateTime?> GetTimelineDates()
        {
            var odates = from om in _context.NewOrderMain
                         select om.OrderDate;
            var ddates = from dm in _context.NewDeliveryMain
                         select dm.DeliveryDate;
            var dates = odates.Union(ddates).OrderByDescending(p => p).ToList();

            return dates;
        }

        public IList<TimelineData> GetTimelineData()
        {
            var list = new List<TimelineData>();
            foreach (var date in GetTimelineDates())
            {
                var orders = GetOrders().Where(p => p.Main.OrderDate == date).ToList();
                var deliveryOrders = GetDeliveryOrders().Where(p => p.Main.DeliveryDate == date).ToList();
                var collections = GetCollections().Where(p => p.Main.CollectionDate == date).ToList();
                list.Add(new TimelineData
                {
                    Date = date,
                    Orders = orders,
                    DeliveryOrders = deliveryOrders,
                    Collections = collections
                });
            }
            return list;
        }
    }
}