﻿namespace DataAccess.Models.DTOs.Product
{
    public class UpdateProductRequest
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public string? ImageURL { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    }
}
