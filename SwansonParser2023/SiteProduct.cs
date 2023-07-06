﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SwansonParser2023;

public class SiteProduct
{
    [JsonPropertyName("productVendor")]
    public string Vendor { get; set; }

    [JsonPropertyName("productName")]
    public string Title { get; set; }

    [JsonPropertyName("productPartNumber")]
    public string Number { get; set; }

    [JsonPropertyName("productDetails")]
    public string Details { get; set; }

    [JsonPropertyName("productDiscountPrice")]
    public string Price { get; set; }

    [JsonPropertyName("statusMessage")]
    public string Status { get; set; }

    [JsonPropertyName("longURL")]
    public string Url { get; set; }

    public string FullUrl
    {
        get
        {
            return $"https://www.swansonvitamins.com/{Url}";
        }

    }

    public string ImageUrl
    {
        get
        {
            return $"https://media.swansonvitamins.com/images/items/master/{Number}.jpg";
        }

    }

}
