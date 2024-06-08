using BuinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuinessLayer.Concreate
{
    public class UserMessageManager : IUserMesaageService
    {
        IUserMessageDal _usermessageDal;
        public UserMessageManager(IUserMessageDal usermessageDal)
        {
            _usermessageDal = usermessageDal;
        }

        public List<UserMessage> GetUserMessageWithUserService()
        {
            return _usermessageDal.GetUserMessagesWithUser();
        }

        public void TAdd(UserMessage t)
        {
            _usermessageDal.Insert(t);
        }

        public void TDelete(UserMessage t)
        {
            _usermessageDal.Delete(t);
        }

        public UserMessage TGetById(int id)
        {
            return _usermessageDal.GetById(id);
        }

        public List<UserMessage> TGetByList()
        {
            return _usermessageDal.GetList();
        }

        public void TUpdate(UserMessage t)
        {
            _usermessageDal.Update(t);
        }
    }
}
