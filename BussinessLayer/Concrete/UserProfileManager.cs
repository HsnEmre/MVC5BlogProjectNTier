using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class UserProfileManager
    {
        Repository<Author> repoUser = new Repository<Author>();
        Repository<Blog> repoUserBlog = new Repository<Blog>();

        public List<Author> GetAuthorByMail(string mail)
        {
            return repoUser.List(x => x.AuthorMail == mail);
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return repoUserBlog.List(x => x.AuthorID == id);
        }

        public int EditAuthor(Author p)
        {
            Author author = repoUser.Find(x => x.AuthorID == p.AuthorID);
            author.AboutShort= p.AboutShort;
            author.AuthorNameSurname= p.AuthorNameSurname;
            author.AuthorImage=p.AuthorImage;
            author.AuthorAbout = p.AuthorAbout;
            author.AuthorTitle = p.AuthorTitle;
            author.AuthorMail = p.AuthorMail;
            author.Password = p.Password;
            author.PhoneNumber=p.PhoneNumber;
            return repoUser.Update(author);

        }

    }
}
