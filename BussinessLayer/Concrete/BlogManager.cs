using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class BlogManager
    {

        Repository<Blog> RepoBlog = new Repository<Blog>();

        public List<Blog> GetAll()
        {
            return RepoBlog.List();
        }

        public List<Blog> GetBlogById(int id)
        {
            return RepoBlog.List(x => x.BlogID == id);//ilgili sınıfa ait parametre bu bir şart değil
        }

        public List<Blog> GetblogByauthor(int id)
        {
            return RepoBlog.List(x => x.AuthorID == id);
        }


        public List<Blog> GetBlogByCategory(int id)
        {
            return RepoBlog.List(x => x.CategoryID == id);
        }

        public int BlogAddBL(Blog b)
        {
            if (!string.IsNullOrEmpty(b.BlogTitle)
                && !string.IsNullOrEmpty(b.BlogImage)
                && b.BlogTitle.Length <= 3
                && b.BlogContent.Length <= 200)
            { return -1; }
            return RepoBlog.Insert(b);

        }

        public int DeleteBlogBL(int p)//TODO:şart eklenecek3
        {
            Blog blog = RepoBlog.Find(x => x.BlogID == p);
            return RepoBlog.Delete(blog);
        }


        public Blog FindBlog(int id)
        {
            return RepoBlog.Find(x => x.BlogID == id);
        }

        public int UpdateBlog(Blog p)
        {
            Blog blog = RepoBlog.Find(x => x.BlogID == p.BlogID);
            blog.BlogTitle = p.BlogTitle;
            blog.BlogContent=p.BlogContent;
            blog.BlogImage = p.BlogImage;
            blog.BlogDate= p.BlogDate;
            blog.Categories = p.Categories;
            blog.CategoryID = p.CategoryID; 
            blog.AuthorID= p.AuthorID;
            return RepoBlog.Update(blog);
        }

    }
}
