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
    public class UserManager : IUserService
    {
        IUserDal _userdal;
        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }
        public void TAdd(User t)
        {
            _userdal.Insert(t);
        }

        public void TDelete(User t)
        {
            _userdal.Delete(t);
        }

        public List<User> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public User TGetById(int id)
        {
            return _userdal.GetById(id);
        }

        public List<User> TGetByList()
        {
            return _userdal.GetList();
        }

        public void TUpdate(User t)
        {
            _userdal.Update(t);
        }
    }
}
