using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        private ICityDal _cityDal;
        private ICountryService _countryService;    // a service must not call a diffirent entity's dal class, it just call diffirent service


        public CityManager(ICityDal cityDal, ICountryService countryService)
        {
            _cityDal = cityDal;
            _countryService = countryService;
        }





        public IResult Add(City city)
        {

            // business rules are checked

            IResult result = BusinessRules.Run(CheckIfCityNameExist(city.Name), ChectIfCityCountOfCountryCorrect(city.CountryId), CheckIfCountryCount());
            if (result != null)
            {
                return result;
            }


            _cityDal.Add(city);
            return new SuccessResult(Messages.CityCreated);
        }

        public IResult Delete(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult(Messages.CityDeleted);
        }
        public IResult Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult(Messages.CityUpdated);
        }
        public IDataResult<City> GetByPlateCode(int plateCode)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c => c.PlateCode == plateCode));
        }

        public IDataResult<List<City>> GetList()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetList().ToList(), Messages.CityListed);
        }




        ///////   Rules    /////////

        private IResult ChectIfCityCountOfCountryCorrect(int countryId)   // A country cannot have more than 20 cities.
        {
            var result = _cityDal.GetList(x => x.CountryId == countryId).Count();
            if (result > 20)
            {
                return new ErrorResult(Messages.CityCountOfCountryError);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCityNameExist(string cityName)
        {
            var result = _cityDal.GetList(x => x.Name == cityName).Any();
            if (result)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        private IResult CheckIfCountryCount()
        {
            var result = _countryService.GetList();
            if (result.Data.Count > 20)
            {
                return new ErrorResult(Messages.CountryCountLimitExceded);
            }
            return new SuccessResult();
        }

    }
}
