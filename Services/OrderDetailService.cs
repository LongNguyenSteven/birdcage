using BussinessObject.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services;

public class OrderDetailService : IOrderDetailService
{
    private readonly IOrderDetailRepository orderDetailRepository;

    public OrderDetailService()
    {
        orderDetailRepository = new OrderDetailRepository();
    }
        public void AddOrderDetail(OrderDetail orderDetail)
    {
        orderDetailRepository.AddOrderDetail(orderDetail);
    }

    public void DeleteOrderDetail(OrderDetail orderDetail)
    {
        orderDetailRepository.DeleteOrderDetail(orderDetail);
    }

    public OrderDetail GetOrderDetailById(string id)
    {
        return orderDetailRepository.GetOrderDetailById(id);
    }

    public List<OrderDetail> GetOrderDetails()
    {
        return orderDetailRepository.GetOrderDetail();
    }

    public void UpdateOrderDetail(OrderDetail orderDetail)
    {
        orderDetailRepository.UpdateOrderDetail(orderDetail);
    }
}
