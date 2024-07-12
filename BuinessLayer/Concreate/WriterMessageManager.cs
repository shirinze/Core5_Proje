using BuinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public List<WriterMessage> GetListRecieverMessage(string p)
        {
            return _writermessageDal.GetbyFilter(x => x.Reciever == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writermessageDal.GetbyFilter(x => x.Sender == p);
        }

        public void TAdd(WriterMessage t)
        {
            _writermessageDal.Insert(t);
        }

        public void TDelete(WriterMessage t)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public WriterMessage TGetById(int id)
        {
            return _writermessageDal.GetById(id);
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
