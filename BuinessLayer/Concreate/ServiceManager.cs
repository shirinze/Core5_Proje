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
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }
        public void TAdd(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void TDelete(Service t)
        {
           _serviceDal.Delete(t);
        }

        public List<Service> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public Service TGetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> TGetByList()
        {
            return _serviceDal.GetList();
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
