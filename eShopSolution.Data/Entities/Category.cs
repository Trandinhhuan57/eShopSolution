﻿using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Category
    {
        public int ID { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int ParentID { set; get; }
        public Status Status { set; get; }

        public List<ProductInCategory> ProductInCategories { set; get; }
        public List<CategoryTranslation> CategoryTranslations { set; get; }

    }
}
