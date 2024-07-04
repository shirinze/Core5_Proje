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
    public class SocialmediaManager : ISocialmediaService
    {
        ISocialMediaDal _socialDal;
        public SocialmediaManager(ISocialMediaDal socialDal)
        {
            _socialDal = socialDal;
        }
        public void TAdd(SocialMedia t)
        {
            _socialDal.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialDal.Delete(t);
        }

        public List<SocialMedia> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public SocialMedia TGetById(int id)
        {
           return _socialDal.GetById(id);
        }

        public List<SocialMedia> TGetByList()
        {
           return _socialDal.GetList();
        }

        public void TUpdate(SocialMedia t)
        {
            _socialDal.Update(t);
        }
    }
}
