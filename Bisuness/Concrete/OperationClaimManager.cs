using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OperationClaimManager : IOperationClaimService
    {
        private IOperationClaimDal _operationClaimDal;

        public OperationClaimManager(IOperationClaimDal operationClaimDal)
        {
            _operationClaimDal = operationClaimDal;
        }

        public IResult Add(OperationClaim operationClaim)
        {
            _operationClaimDal.Add(operationClaim);
            return new SuccessResult(Messages.OperationClaimCreated);
        }


        public IDataResult<OperationClaim> GetClaimByName(string claimName)
        {

            return new SuccessDataResult<OperationClaim>(_operationClaimDal.Get(x => x.Name.ToLower() == claimName.ToLower()),Messages.OperationClaimGetByName);
        }

        public IDataResult<List<OperationClaim>> GetClaims()
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationClaimDal.GetList().ToList(), Messages.OperationClaimListed);
        }
    }
}
