﻿namespace ChainOfResponsability.Domain.Models
{
    public class Status : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int? Order { get; set; }
        public string? Chain { get; set; }
    }
}
