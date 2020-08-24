using CodingTest.Models;
using System;
using System.Collections.Generic;

namespace CodingTest.Business
{
    public class Promotion
    {
        // Load it from database
        public List<Product> LoadProduct()
        {
            var products = new List<Product>();

            var product = new Product
            {
                Id = 1,
                SKUId = "A",
                UnitPrice = 50
            };

            products.Add(product);

            product = new Product
            {
                Id = 2,
                SKUId = "B",
                UnitPrice = 30
            };

            products.Add(product);

            product = new Product
            {
                Id = 3,
                SKUId = "C",
                UnitPrice = 20
            };

            products.Add(product);

            product = new Product
            {
                Id = 4,
                SKUId = "D",
                UnitPrice = 15
            };

            products.Add(product);

            return products;
        }

        public decimal CalculateOrder(List<Order> orders)
        {
            decimal orderValue = 0;

            foreach (var order in orders)
            {
                decimal amountByQuotient = 0;
                decimal amountByRemainder = 0;

                if (order.ProductId == 1)
                {
                    amountByQuotient = (order.Qty / 3) * 130; // ToDo 
                    amountByRemainder = (order.Qty % 3) * order.UnitPrice;

                    order.Amount = amountByQuotient + amountByRemainder;

                    orderValue = orderValue + order.Amount;
                }
                else if (order.ProductId == 2)
                {
                    amountByQuotient = (order.Qty / 2) * 45; // ToDo 
                    amountByRemainder = (order.Qty % 2) * order.UnitPrice;

                    order.Amount = amountByQuotient + amountByRemainder;

                    orderValue = orderValue + order.Amount;
                }
                else if (order.ProductId == 3)
                {
                    var item = orders.Find(x => x.ProductId == 4);

                    if (item == null)
                    {
                        order.Amount = order.Qty * order.UnitPrice;
                        orderValue = orderValue + order.Amount;
                    }
                }
                else if (order.ProductId == 4)
                {
                    var item = orders.Find(x => x.ProductId == 3);

                    if (item == null)
                    {
                        order.Amount = order.Qty * order.UnitPrice;
                        orderValue = orderValue + order.Amount;
                    }
                    else
                    {
                        var qty = Math.Abs(order.Qty - item.Qty);
                        var act = order.Qty >= item.Qty ? (order.Qty - item.Qty) * order.UnitPrice : (item.Qty - order.Qty) * item.UnitPrice;
                        var ori = order.Qty >= item.Qty ? (order.Qty - qty) * 30 : (item.Qty - qty) * 30;

                        orderValue = orderValue + (act + ori);
                    }
                }

            }

            return orderValue;
        }

    }
}
