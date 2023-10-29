using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;

        public OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailDAO();
                }
                return instance;
            }
        }
        public List<OrderDetail> GetOrderDetail()
        {
            var dbContext = new BirdCageShopContext();
            return dbContext.OrderDetails.ToList();
        }
        public OrderDetail GetOrderDetailById(string id)
        {
            var dbContext = new BirdCageShopContext();
            return dbContext.OrderDetails.SingleOrDefault(m => m.OrderDetailId.Equals(id));
        }
        public void AddOrderDetail(OrderDetail OrderDetails)
        {
            try
            {
                var dbContext = new BirdCageShopContext();
                OrderDetail p = GetOrderDetailById(OrderDetails.OrderDetailId);
                if (p == null)
                {
                    dbContext.OrderDetails.Add(OrderDetails);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Id has existed!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateOrderDetail(OrderDetail OrderDetails)
        {
            try
            {
                var dbContext = new BirdCageShopContext();
                if (OrderDetails != null)
                {
                    dbContext.OrderDetails.Update(OrderDetails);
                    dbContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Nothing to update!");
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteOrderDetails(OrderDetail OrderDetails)
        {
            try
            {
                var dbContext = new BirdCageShopContext();
                if (OrderDetails != null)
                {
                    dbContext.OrderDetails.Remove(OrderDetails);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Nothing to delete!");
            }
        }
    }
}
