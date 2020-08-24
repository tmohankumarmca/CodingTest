using CodingTest.Business;
using CodingTest.Models;
using System;
using System.Collections.Generic;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var promotion = new Promotion();
            var products = promotion.LoadProduct();

            var orders = new List<Order>();
            foreach (var product in products) {
                var order = new Order();

                Console.WriteLine("Please Enter Qty for " + product.SKUId);

                var qty = Convert.ToInt32(Console.ReadLine());

                if (qty > 0) {
                    order.Id = 1; // Change it later
                    order.ProductId = product.Id;
                    order.Qty = qty;
                    order.UnitPrice = product.UnitPrice;
                    orders.Add(order);
                }

            }

            var totalAMount = promotion.CalculateOrder(orders);

            Console.WriteLine("Order value " + totalAMount);
            Console.ReadLine();
        }        
    }
}
