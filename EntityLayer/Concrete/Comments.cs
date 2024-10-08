﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comments
    {
        [Key]
        public int CommentID { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(20)]
        public string Mail { get; set; }
        [StringLength(500)]
        public string CommentText { get; set; }
        public int BlogRating { get; set; }

        public bool CommentStatus { get; set; }
        public DateTime CommentDate { get; set; }
        #region RealtionBlog
        public int BlogID { get; set; }
        public virtual Blog Blogs { get; set; }
        #endregion
    }
}
