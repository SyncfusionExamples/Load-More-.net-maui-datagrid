﻿using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace SfDataGridLoadMoreSample
{
    public class OrderInfo
    {
        private int orderID;
        private string? customerID;
        private string? customer;
        private string? shipCity;
        private string? shipCountry;

        public int OrderID
        {
            get { return orderID; }
            set { this.orderID = value; }
        }

        public string? CustomerID
        {
            get { return customerID; }
            set { this.customerID = value; }
        }

        public string? ShipCountry
        {
            get { return shipCountry; }
            set { this.shipCountry = value; }
        }

        public string? Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public string? ShipCity
        {
            get { return shipCity; }
            set { this.shipCity = value; }
        }

        public OrderInfo(int orderId, string customerId, string country, string customer, string shipCity)
        {
            this.OrderID = orderId;
            this.CustomerID = customerId;
            this.Customer = customer;
            this.ShipCountry = country;
            this.ShipCity = shipCity;
        }
    }
}
