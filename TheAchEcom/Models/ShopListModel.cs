using System;
using System.Collections.Generic;
using Repository.DomainModels;
using Repository.BusinessModels;
using Repository.BusinessModels.ShopList;
using System.ComponentModel.DataAnnotations;

namespace TheAchEcom.Models
{
    public class ShopListModel
    {
        public IEnumerable<ShopListItem> ShopList { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
    }
}
