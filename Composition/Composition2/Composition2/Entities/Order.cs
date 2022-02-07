using System;
using System.Collections.Generic;
using System.Text;
using Composition2.Entities.Enums;

namespace Composition2.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order ()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach(OrderItem orderItem in OrderItems)
            {
                total += orderItem.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMARRY:");
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString());
            sb.AppendLine("Order Status: " + Status.ToString());
            sb.Append("Client: " + Client.Name);
            sb.Append(" (" + Client.BirthDate.ToString("dd/MM/yyyy") + ")");
            sb.AppendLine(" - " + Client.Email);
            sb.AppendLine("Order Items:");
            foreach(OrderItem item in OrderItems)
            {
                sb.Append(item.Product.Name);
                sb.Append(", Quantity: " + item.Quantity);
                sb.AppendLine(", Subtotal:" + item.SubTotal());
            }
            sb.AppendLine("Total Price: " + Total());
            return sb.ToString();
        }
    }
}
