using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        [StringLength(100)]
        public string BlogTitle { get; set; }
        [StringLength(200)]
        public string BlogImage { get; set; }

        public DateTime BlogDate { get; set; }
        public string BlogContent { get; set; }

        public int BlogRating { get; set; }

        #region RelationCategory
        public int CategoryID { get; set; }
        public virtual Categories Categories { get; set; }
        #endregion

        #region RelationAuthor
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }
        #endregion,


        #region Relations Comments
        public ICollection<Comments> Comments { get; set; }
        #endregion
    }
}
