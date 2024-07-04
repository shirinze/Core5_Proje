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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writermessageDal;
        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writermessageDal = writerMessageDal;
        }

        public void TAdd(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> TGetByList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(WriterMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
