using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class SubscribeMailManager
    {
        Repository<SubscribeMail> repoSubscribeMail=new Repository<SubscribeMail>();
        public int BLAdd(SubscribeMail parameter)
        {
            if (parameter.Mail.Length<=10 || parameter.Mail.Length>=50 || !parameter.Mail.Contains("@"))
            {
                return -1;
            }
            return repoSubscribeMail.Insert(parameter);
        }
    }
}
