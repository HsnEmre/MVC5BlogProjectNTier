using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BussinessLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comments> repositoryComment = new Repository<Comments>();


        public List<Comments> CommentList()
        {
            return repositoryComment.List();
        }

        public List<Comments> CommentByBlog(int id)
        {
            return repositoryComment.List(x => x.BlogID == id);
        }
        public List<Comments> CommentByStatusTrue()
        {
            return repositoryComment.List(x => x.CommentStatus == true);
        }
        public int CommentAdd(Comments c)
        {
            if (c.CommentText.Length <= 4
                || c.CommentText.Length >= 500
                || c.UserName == ""
                || c.Mail == ""
                || c.UserName.Length <= 5)
            {
                return -1;
            }
            return repositoryComment.Insert(c);
        }

        public int ChangeCommentStatusToFalse(int id)
        {
            Comments comment = repositoryComment.Find(x => x.CommentID == id);
            comment.CommentStatus = false;
            return repositoryComment.Update(comment);
        }


        public List<Comments> CommentStatusFalse()
        {
            return repositoryComment.List(x => x.CommentStatus == false);
        }
        public int ChangeCommentStatusToTrue(int id)
        {
            Comments comment = repositoryComment.Find(x => x.CommentID == id);
            comment.CommentStatus = true;
            return repositoryComment.Update(comment);
        }

        public void TAdd(Comments t)
        {
            repositoryComment.Insert(t);
        }

        public void TDelete(Comments t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comments t)
        {
            throw new NotImplementedException();
        }
    }
}
