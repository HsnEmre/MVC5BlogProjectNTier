using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repoblog = new Repository<Author>();

        public List<Author> GetAll()
        {
            return repoblog.List();
        }

        public int AddAuthorBL(Author p)
        {
            if (string.IsNullOrEmpty(p.AuthorNameSurname)
                && string.IsNullOrEmpty(p.AboutShort)
                && string.IsNullOrEmpty(p.AuthorTitle))
            {
                return -1;

            }

            return repoblog.Insert(p);
        }


        public Author FindAuthor(int id)
        {
            return repoblog.Find(x => x.AuthorID == id);
        }


        public int EditAuthor(Author p)
        {
            Author author = repoblog.Find(x => x.AuthorID == p.AuthorID);
            author.AboutShort = p.AboutShort;
            author.Password= p.Password;
            author.AuthorMail = p.AuthorMail;
            author.AuthorAbout = p.AuthorAbout;
            author.AboutShort = p.AboutShort;
            author.Blogs = p.Blogs;
            author.AuthorImage = p.AuthorImage;
            author.AuthorNameSurname = p.AuthorNameSurname;
            author.AuthorTitle = p.AuthorTitle;
            return repoblog.Update(author);
        }

    }
}
