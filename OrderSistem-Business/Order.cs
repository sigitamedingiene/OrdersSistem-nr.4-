﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSistem_Business
{
    public class Order
    {
        public int Id { get;}
        public Client Client { get;}
        public Service Service { get;}
        public DateTime DateTimeCreated { get;}
        public int Quantity { get; }
        public bool IsPaid { get; }

        public Order (int id, Client client, Service service, DateTime dateTimeCreated, int quantity, bool isPaid)
        {
            Id = id;
            Client = client;
            Service = service;
            DateTimeCreated = dateTimeCreated;
            Quantity = quantity;
            IsPaid = isPaid;
        }

        public decimal CountPrice()
        {
            decimal price = 0;
            price = Quantity * Service.Price;
            return price;
        }
    }
}
