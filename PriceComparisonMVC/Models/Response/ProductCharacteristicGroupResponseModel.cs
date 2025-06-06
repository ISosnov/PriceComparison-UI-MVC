﻿namespace PriceComparisonMVC.Models.Response
{
    public class ProductCharacteristicGroupResponseModel
    {
        public int CharacteristicGroupId { get; set; }
        public string CharacteristicGroupTitle { get; set; }
        public int GroupDisplayOrder { get; set; }
        public IEnumerable<ProductCharacteristicResponseModel> ProductCharacteristics { get; set; }
    }
}
