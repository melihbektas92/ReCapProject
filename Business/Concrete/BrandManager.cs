using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        Brand brand = new Brand();

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> AddBrand()
        {
            throw new NotImplementedException();

        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

    }
}
