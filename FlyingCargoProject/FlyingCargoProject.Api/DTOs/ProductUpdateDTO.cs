﻿namespace FlyingCargoProject.Api.DTOs
{
    public class ProductUpdateDTO
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int StockQuantity { get; set; }
    }
}