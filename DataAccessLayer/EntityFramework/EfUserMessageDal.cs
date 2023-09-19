using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
    {
        //Bu metod IUserMessageDal da ekledigimiz metottur. Ve bu eklenecek IUSerMessageService te. Ondan sonra impletende edilecek UserMessageManagerda.
        public List<UserMessage> GetUserMessagesWithUser()
        {
            using (var c = new Context())
            {
                return c.UserMessages.Include(x => x.User).ToList();
            }
        }
    }
}
