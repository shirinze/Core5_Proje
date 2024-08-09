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
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _writeruserDal;
        public WriterUserManager(IWriterUserDal writeruserDal)
        {
            _writeruserDal = writeruserDal;
        }
        public void TAdd(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterUser t)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public WriterUser TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterUser> TGetByList()
        {
            return _writeruserDal.GetList();
        }

        public void TUpdate(WriterUser t)
        {
            throw new NotImplementedException();
        }
    }
}
