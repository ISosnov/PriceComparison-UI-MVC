﻿namespace PriceComparisonMVC.Models.Categories
{
    public class ProductToCategoriesListModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }
        public int FirstProductId { get; set; }
    }
}
