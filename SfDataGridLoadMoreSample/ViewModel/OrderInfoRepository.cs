using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridLoadMoreSample
{
    public class OrderInfoRepository
    {
        private Random random = new Random();
        private ObservableCollection<OrderInfo> orderInfo;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        public OrderInfoRepository()
        {
            orderInfo = this.GenerateOrders(25);
        }

        public void LoadMoreItems()
        {
            for (int i = 0; i < 10; i++)
                this.OrderInfoCollection.Add(this.GenerateOrderInfo(OrderInfoCollection.Count));
        }

        public OrderInfo GenerateOrderInfo(int count)
        {
            var order = new OrderInfo(
                count + 1000, CustomerID[random.Next(7)],
                Country[random.Next(7)],
                Customer[random.Next(7)],
                ShipCity[random.Next(7)]);

            return order;
        }

        public ObservableCollection<OrderInfo> GenerateOrders(int count)
        {
            ObservableCollection<OrderInfo> orders = new ObservableCollection<OrderInfo>();
            for (int i = 1000; i <= 1000 + count; i++)
            {
                var order = new OrderInfo(i,
                    CustomerID[random.Next(7)],
                    Country[random.Next(7)],
                    Customer[random.Next(7)],
                    ShipCity[random.Next(7)]);
                orders.Add(order);
            }
            return orders;
        }

        string[] CustomerID = new string[]
        {
            "Maria Anders",
            "Ana Trujillo",
            "Ant Fuller",
            "Thomas Hardy",
            "Tim Adams",
            "Hanna Moos",
            "Andrew Fuller",
            "Martin King",
            "Lenny Lin",
            "John Carter",
            "Laura King",
            "Anne Wilson",
            "Martin King",
            "Gina Irene"
        };

        string[] Country = new string[]
        {
            "Germany",
            "Mexico",
            "Mexico",
            "UK",
            "Sweden",
            "Germany",
            "France",
            "Spain",
            "France",
            "Canada",
            "UK",
            "Germany",
            "France",
            "UK"
        };

        string[] Customer = new string[]
        {
            "ALFKI",
            "ANATR",
            "ANTON",
            "AROUT",
            "BERGS",
            "BLAUS",
            "BLONP",
            "BOLID",
            "BONAP",
            "BOTTM",
            "AROUT",
            "BLAUS",
            "BLONP",
            "AROUT"
        };

        string[] ShipCity = new string[]
        {
            "Berlin",
            "Mexico D.F.",
            "Mexico D.F.",
            "London",
            "London",
            "Mannheim",
            "Strasbourg",
            "Madrid",
            "Marsiella",
            "Lenny Lin",
            "London",
            "Mannheim",
            "Strasbourg",
            "London"
        };
    }

}
