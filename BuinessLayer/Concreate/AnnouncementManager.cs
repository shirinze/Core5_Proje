using BuinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuinessLayer.Concreate
{
    public class AnnouncementManager :IAnnouncementService
    {
        IAnnouncementDal _announceDal;
        public AnnouncementManager(IAnnouncementDal announceDal)
        {
            _announceDal = announceDal;
        }
        public void TAdd(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public Announcement TGetById(int id)
        {
            return _announceDal.GetById(id);
        }

        public List<Announcement> TGetByList()
        {
            return _announceDal.GetList();
        }

        public void TUpdate(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
