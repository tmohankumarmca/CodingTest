using CodingTest.Business;
using CodingTest.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitCodingTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ScenarioA()
        {
            var promotion = new Promotion();
            var products = promotion.LoadProduct();
            var orders = new List<Order>();

            foreach (var product in products)
            {
                var order = new Order();

                if (product.Id == 1)
                {
                    order.Id = 1;
                    order.ProductId = product.Id;
                    order.Qty = 1;
                    order.UnitPrice = product.UnitPrice;
                    orders.Add(order);
                }
                else if (product.Id == 2)
                {
                    order.Id = 1;
                    order.ProductId = product.Id;
                    order.Qty = 1;
                    order.UnitPrice = product.UnitPrice;
                    orders.Add(order);
                }
                else if (product.Id == 3)
                {
                    order.Id = 1;
                    order.ProductId = product.Id;
                    order.Qty = 1;
                    order.UnitPrice = product.UnitPrice;
                    orders.Add(order);
                }              

            }

            var totalAMount = promotion.CalculateOrder(orders);

            Assert.AreEqual(totalAMount, 100); // Scenario A
        }

        [Test]
        public void ScenarioB()
        {
            var promotion = new Promotion();
            var products = promotion.LoadProduct();
            var orders = new List<Order>();

            foreach (var product in products)
            {
                var order = new Order();

                if (product.Id == 1)
                {
                    order.Id = 1;
                    order.ProductId = product.Id;
                    order.Qty = 5;
                    order.UnitPrice = product.UnitPrice;
                    orders.Add(order);
                }
                else if (product.Id == 2)
                {
                    order.Id = 1;
                    order.ProductId = product.Id;
                    order.Qty = 5;
                    order.UnitPrice = product.UnitPrice;
                    orders.Add(order);
                }
                else if (product.Id == 3)
                {
                    order.Id = 1;
                    order.ProductId = product.Id;
                    order.Qty = 1;
                    order.UnitPrice = product.UnitPrice;
                    orders.Add(order);
                }

            }

            var totalAMount = promotion.CalculateOrder(orders);

            Assert.AreEqual(totalAMount, 370); // Scenario B
        }

        [Test]
        public void ScenarioC()
        {
            var promotion = new Promotion();
            var products = promotion.LoadProduct();
            var orders = new List<Order>();

            foreach (var product in products)
            {
                var order = new Order();

                if (product.Id == 1)
                {
                    order.Id = 1;
                    order.ProductId = product.Id;
                    order.Qty = 3;
                    order.UnitPrice = product.UnitPrice;
                    orders.Add(order);
                }
                else if (product.Id == 2)
                {
                    order.Id = 1;
                    order.ProductId = product.Id;
                    order.Qty = 5;
                    order.UnitPrice = product.UnitPrice;
                    orders.Add(order);
                }
                else if (product.Id == 3)
                {
                    order.Id = 1;
                    order.ProductId = product.Id;
                    order.Qty = 1;
                    order.UnitPrice = product.UnitPrice;
                    orders.Add(order);
                }
                else if (product.Id == 4)
                {
                    order.Id = 1;
                    order.ProductId = product.Id;
                    order.Qty = 1;
                    order.UnitPrice = product.UnitPrice;
                    orders.Add(order);
                }

            }

            var totalAMount = promotion.CalculateOrder(orders);

            Assert.AreEqual(totalAMount, 280); // Scenario C
        }
    }
}