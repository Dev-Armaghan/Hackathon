﻿namespace AuthenticationAuthorization.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }

        public string Description { get; set; }
        public string Tags { get; set; }


    }
}
