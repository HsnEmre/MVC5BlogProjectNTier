using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        [StringLength(50)]
        public string AuthorNameSurname { get; set; }
        [StringLength(100)]
        public string AuthorImage { get; set; }
        [StringLength(300)]
        public string AuthorAbout { get; set; }

        #region RelationsBlog
        public ICollection<Blog> Blogs { get; set; }
        #endregion

    }
}
