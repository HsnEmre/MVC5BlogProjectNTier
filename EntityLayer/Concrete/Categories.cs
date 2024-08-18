﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]   
        public string CategoryName { get; set; }

        [StringLength(500)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
