﻿namespace class04.Entities
{
    public class Order : BaseEntity
    {
        public string Receiver {  get; set; }
        public string Address { get; set; }

        public override string GetInfo()
        {
            return $"{Id} | {Receiver} ({Address})";
                }
    }
}
