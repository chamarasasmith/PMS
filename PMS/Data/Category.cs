using System;
using System.Collections.Generic;

namespace PMS.Data
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }

        public List<Item> Items { get; set; }
    }
}
