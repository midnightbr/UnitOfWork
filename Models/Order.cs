﻿namespace UnitOfWork.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
